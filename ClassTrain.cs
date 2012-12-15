using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Xml;
using System.Drawing;

namespace Trains
{

    class Train
    {
        int             _number;
        List<Ticket>    _tickets;
        List<RouteNode>  _routenodes;

        /// <summary>
        /// ����������� ������ ���� �������.
        /// </summary>
        static List<Train> _allTrains = new List<Train>();

        /// <summary>
        /// �������������� ����� �� ��� ������, ������ ������ ������ ����������
        /// � ��������� ����� � ������ ���� �������.
        /// </summary>
        /// <param name="NumberOfTrain">����� ������.</param>
        public Train(int NumberOfTrain)
        {
            this.Number         = NumberOfTrain;
            this._tickets       = new List<Ticket>();
            this._routenodes    = new List<RouteNode>();
            AddToAllTrains();
        }
        /// <summary>
        ///  ��������� ����� � ������ ���� �������.
        /// </summary>
        private void AddToAllTrains()
        {
            _allTrains.Add(this);
        }

        /// <summary>
        /// ������� ����� �� ������ ���� �������.
        /// </summary>
        public void RemoveFromAllTrains()
        {
            _allTrains.Remove(this);
        }

        /// <summary>
        /// ������������� ������ �� �����. ��������� ����� 
        /// � ������ ������� ������.
        /// </summary>
        /// <param name="Ticket"></param>
        public void AddTicket(Ticket Ticket)
        {
            this._tickets.Add(Ticket);
        }

        /// <summary>
        /// ��������� ���� �������� � ����� �������� ������.
        /// </summary>
        /// <param name="RouteNode"></param>
        public void AddRouteNode(RouteNode RouteNode)
        {
            this._routenodes.Add(RouteNode);
            RouteNodeComparer rnc = new RouteNodeComparer();
            this._routenodes.Sort(rnc);
        }

        /// <summary>
        /// ���� ������� �� �������� ������ �� ������� �����������/��������.
        /// </summary>
        /// <param name="time">����� ����������� ��� ����� ��������.</param>
        /// <returns></returns>
        private Station SearchStationByTime(DateTime time)
        {
            List<RouteNode> rnds = this.RouteNodes;
            foreach(RouteNode rnd in rnds)
            {
                if ((rnd.TimeOfArrivalFormat == time)||(rnd.TimeOfDepartureFormat == time))
                {
                    return rnd.Station;
                }
            }
            return null;
        }


        /// <summary>
        /// ���������� �������������� ������ � ��������� ������ �������.
        /// </summary>
        /// <param name="time">�������� ������ �������.</param>
        /// <returns></returns>
        public PointF Location(DateTime time)
        {
            List<RouteNode> rnds    = this.RouteNodes;
            List<DateTime>  ldt     = new List<DateTime>();
            foreach(RouteNode rnd in rnds)
            {
                ldt.Add(rnd.TimeOfDepartureFormat);
                ldt.Add(rnd.TimeOfArrivalFormat);
            }
            ldt.Add(time);
            ldt.Sort();
            int i1  = ldt.IndexOf(time) - 1;
            int i2  = i1 + 2;
            if ( (i1 >= 0) && (i2 < rnds.Count) )
            {
                DateTime    t1  = ldt[i1];
                DateTime    t2  = ldt[i2];
                TimeSpan    dt  = t2 - t1;
                TimeSpan    dt1 = time - t1;
                double      mylbd = dt1.TotalSeconds / dt.TotalSeconds;
                Station     st1 = this.SearchStationByTime(t1);
                Station     st2 = this.SearchStationByTime(t2);
                int         X1  = st1.X;
                int         Y1  = st1.Y;
                int         X2  = st2.X;
                int         Y2  = st2.Y;
                float       lbd = Convert.ToSingle(mylbd);
                PointF      p   = new PointF(   (X1 + lbd * X2) / (1 + lbd),
                                                (Y1 + lbd * Y2) / (1 + lbd));
                return      p;
            }
            else
            {
                return (new PointF(-100, -100));
            }
        }


        #region ����� � ��������� � ��� ������

        /// <summary>
        /// ���� ����� �� ��� ������. � ������ ��������� ������ ����������
        /// �����. � ������ ������� ���������� null.
        /// </summary>
        /// <param name="Number">����� ������</param>
        /// <returns></returns>
        public static Train Search(int Number)
        {
            foreach (Train Trn in AllTrains)
            {
                if (Trn.Number == Number)
                {
                    return Trn;
                }
            }
            return null;
        }

        /// <summary>
        /// ���� ������ �� ��������� � �������� ��������. � ������ ������ ����������
        /// ������ ����������� �������. � ������ ������� ���������� null.
        /// </summary>
        /// <param name="PointOfDep">������� ��������� �������.</param>
        /// <param name="PointOfArr">������� �������� �������.</param>
        /// <returns></returns>
        public static List<Train> Search(string PointOfDep, string PointOfArr)
        {
            List<Train> Result  = AllTrains;
            
            if (PointOfDep != "")
            {
                Result = SearchByDep(PointOfDep, Result);
            }
            
            if (PointOfArr != "")
            {
                Result = SearchByArr(PointOfArr, Result);
            }

            return Result;
        }

        /// <summary>
        /// ���� ������ �� ��������� �������. � ������ ������ ����������
        /// ������ ����������� �������. � ������ ������� ���������� null.
        /// </summary>
        /// <param name="PointOfArr">�������� �������.</param>
        /// <param name="Trns">������ �������, � ������� ���������� �����.</param>
        /// <returns></returns>
        private static List<Train> SearchByDep(string PointOfDep, List<Train> Trns)
        {
            List<Train> Result  = new List<Train>();
            foreach(Train Trn in Trns)
            {
                if (Trn.PointOfDeparture == PointOfDep)
                {
                    Result.Add(Trn);
                }
            }
            return Result;
        }

        /// <summary>
        /// ���� ������ �� �������� �������. � ������ ������ ����������
        /// ������ ����������� �������. � ������ ������� ���������� null.
        /// </summary>
        /// <param name="PointOfArr">�������� �������.</param>
        /// <param name="Trns">������ �������, � ������� ���������� �����.</param>
        /// <returns></returns>
        private static List<Train> SearchByArr(string PointOfArr, List<Train> Trns)
        {
            List<Train> Result  = new List<Train>();
            foreach(Train Trn in Trns)
            {
                if (Trn.PointOfArrival == PointOfArr)
                {
                    Result.Add(Trn);
                }
            }
            return Result;
        }

        #endregion

        #region ��������

        /// <summary>
        /// ���������� ����� ������.
        /// </summary>
        public int Number
        {
            get { return _number; }
            set { if (value >= 0) _number = value; }
        }

        /// <summary>
        /// ���������� ����������� ���������� ���������� � ������.
        /// </summary>
        public int CountOfPas
        {
            get { return Tickets.Count; }
        }

        /// <summary>
        /// ���������� �������� ��������� �������.
        /// </summary>
        public string PointOfDeparture
        {
            get { return RouteNodes[0].Station.Name; }
        }

        /// <summary>
        /// ���������� �������� �������� �������.
        /// </summary>
        public string PointOfArrival
        {
            get
            {
                int lastIndex = RouteNodes.Count - 1;
                return RouteNodes[lastIndex].Station.Name; 
            }
        }

        /// <summary>
        /// ���������� ����� ����������� ������ � ��������� �������.
        /// </summary>
        public string TimeOfDeparture
        {
            get { return RouteNodes[0].TimeOfDeparture; }
        }

        /// <summary>
        /// ���������� ����� �������� ������ �� �������� �������.
        /// </summary>
        public string TimeOfArrival
        {
            get 
            { 
                int lastIndex   = RouteNodes.Count - 1;
                return RouteNodes[lastIndex].TimeOfArrival;
            }
        }

        /// <summary>
        /// ���������� ������ ������� ������.
        /// </summary>
        public List<Ticket>  Tickets   { get { return _tickets; } } 

        /// <summary>
        /// ���������� ������ ����� ��������, ����� ������� �������� �����.
        /// </summary>
        public List<RouteNode>   RouteNodes    { get { return _routenodes; } }

        /// <summary>
        /// ���������� ������ ���� �������.
        /// </summary>
        static List<Train> AllTrains { get { return _allTrains; } }

        #endregion

    }
}

/*
[TestFixture]
class SearchByParams
{
    Data
}
*/