using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Xml;
using System.Drawing;

namespace Trains
{

    public class Train
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
        /// ������� ������ ���� �������.
        /// </summary>
        public static void Unload()
        {
            _allTrains.Clear();
        }

        public void RemoveTicket(Ticket ticket)
        {
            this._tickets.Remove(ticket);
        }

/// <summary>
/// 
/// </summary>
/// <param name="xmlOut"></param>
        public static void SaveAllTrainsToFile(XmlTextWriter xmlOut)
        {
            xmlOut.WriteStartElement("Trains");

            List<Train> trains = Train.Search("", "");
            foreach(Train train in trains)
            {
                train.SaveToFile(xmlOut);
            }
            xmlOut.WriteEndElement();
        }

        public void SaveToFile(XmlTextWriter xmlOut)
        {
            xmlOut.WriteStartElement("Train");

            xmlOut.WriteElementString("Number", this.Number.ToString());
            RouteNode.SaveRouteNodesToFile(xmlOut, this);
            Passenger.SavePassengersToFile(xmlOut, this);

            xmlOut.WriteEndElement();
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
            List<RouteNode> rns = this._routenodes;
            foreach (RouteNode rn in rns)
            {
                // ������� 1
                rn.Station.RemoveRouteNode(rn);
            }

            // ������� 2
            this._routenodes.Clear();

            List<Ticket> tkts = this._tickets;
            foreach (Ticket tkt in tkts)
            {
                // ������� 3
                tkt.Passenger.RemoveTicket(tkt);
            }
            // ������� 4
            this._tickets.Clear();
          
            // ������� 5
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
        /// ��������� ���� �������� � ���������� ����������.
        /// </summary>
        /// <param name="RouteNode"></param>
        public void AddRouteNode(RouteNode RouteNode)
        {
            this._routenodes.Add(RouteNode);
            RouteNodeComparer rnc = new RouteNodeComparer();
            this._routenodes.Sort(rnc);
        }

        /// <summary>
        /// ������� ���� �������� �� �������� ������.
        /// </summary>
        /// <param name="RouteNode"></param>
        public void RemoveRouteNode(RouteNode routeNode)
        {
            this._routenodes.Remove(routeNode);
        }

        /// <summary>
        /// ���������� ��������� ���� ��������, �� ������� ������� �����. 
        /// � ������, ����� �������� ����� ������ ������� ����������� 
        /// ������ ��� ������ ������� �������� ������, ���������� null.
        /// </summary>
        /// <param name="Time">�����.</param>
        /// <returns></returns>
        private RouteNode NextRouteNode(DateTime Time)
        {            
            // ���������� null, ���� �������� ����� ������
            // ������� ����������� ������ ��� ������ ������� �������� ������
            if ((Time < this.TimeOfDepartureFormat)||(Time > this.TimeOfArrivalFormat))
            {
                return null;
            }
            else
            {
                List<RouteNode> rns = this.RouteNodes;
                foreach(RouteNode rn in rns)
                {
                    if (Time <= rn.TimeOfDepartureFormat)
                    {
                        return rn;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// ���������� ��������� ���� ��������, ������� ����� ��� �������.
        /// � ������, ����� �������� ����� ������ ������� ����������� 
        /// ������ ��� ������ ������� �������� ������, ���������� null.
        /// </summary>
        /// <param name="Time">�����.</param>
        /// <returns></returns>
        private RouteNode PrevRouteNode(DateTime Time)
        {        
            // ���������� null, ���� �������� ����� ������
            // ������� ����������� ������ ��� ������ ������� �������� ������
            if ((Time < this.TimeOfDepartureFormat)||(Time > this.TimeOfArrivalFormat))
            {
                return null;
            }
            else
            {
                List<RouteNode> rns = this.RouteNodes;
                foreach(RouteNode rn in rns)
                {
                    if (Time < rn.TimeOfArrivalFormat)
                    {
                        // ���� �� ���� ���� �����, ����������� � ����������� - ������ �� ��� �����.
                        int index = rns.IndexOf(rn) - 1;
                        return rns[index];
                    }
                }
                // ������� �� �������� �������.
                return rns[rns.Count - 1];
            }
        }

        /// <summary>
        /// ���������� ��������� ���� �� �����, ���� �������� ����� ���������
        /// ����� �������� ����������� � ��������. � ��������� ������ ����������
        /// ����� (-100, -100).
        /// </summary>
        /// <param name="Time">�����.</param>
        /// <returns></returns>
        private PointF NextPoint(DateTime Time)
        {
            RouteNode rn = this.NextRouteNode(Time);
            if (rn == null)
            {
                return new PointF(-100, -100);
            }
            else
            {
                return new PointF(rn.Station.X, rn.Station.Y);
            }
        }

        /// <summary>
        /// ���������� ���������� ���� �� �����, ���� �������� ����� ���������
        /// ����� �������� ����������� � ��������. � ��������� ������ ����������
        /// ����� (-100, -100).
        /// </summary>
        /// <param name="Time">�����.</param>
        /// <returns></returns>
        private PointF PrevPoint(DateTime Time)
        {
            RouteNode rn = this.PrevRouteNode(Time);
            if (rn == null)
            {
                return new PointF(-100, -100);
            }
            else
            {
                return new PointF(rn.Station.X, rn.Station.Y);
            }
        }

        private TimeSpan NextTime(DateTime Time)
        {
            RouteNode rn = this.NextRouteNode(Time);
            if (rn == null)
            {
                return new TimeSpan();
            }
            else
            {
                return rn.TimeOfArrivalFormat - Time;
            }
        }

        private TimeSpan PrevTime(DateTime Time)
        {
            RouteNode rn = this.PrevRouteNode(Time);
            if (rn == null)
            {
                return new TimeSpan();
            }
            else
            {
                return Time - rn.TimeOfDepartureFormat;
            }
        }

        /// <summary>
        /// ���������� �������������� ������ � ��������� ������ �������.
        /// </summary>
        /// <param name="Time">�������� ������ �������.</param>
        /// <returns></returns>
        public PointF Location(DateTime Time)
        {
            PointF      PrevP           = this.PrevPoint(Time);
            PointF      NextP           = this.NextPoint(Time);
            TimeSpan    PrevT           = this.PrevTime(Time);
            TimeSpan    NextT           = this.NextTime(Time);
            double      LambdaDouble    = PrevT.TotalSeconds / NextT.TotalSeconds;
            float       LambdaFloat     = Convert.ToSingle(LambdaDouble);
            PointF      Result          = new PointF(   (PrevP.X + LambdaFloat * NextP.X) / (1 + LambdaFloat),
                                                        (PrevP.Y + LambdaFloat * NextP.Y) / (1 + LambdaFloat));
            return Result;
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
        /// ���������� ����� ����������� ������.
        /// </summary>
        public string TimeOfDeparture
        {
            get { return RouteNodes[0].TimeOfDeparture; }
        }

        ///<summary>
        /// ���������� ����� ����������� ������ � ������� DateTime.
        /// </summary>

        public DateTime TimeOfDepartureFormat
        {
            get { return Convert.ToDateTime(TimeOfDeparture); }
        }

        /// <summary>
        /// ���������� ����� �������� ������.
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
        /// ���������� ����� �������� ������ � ������� DateTime.
        /// </summary>
        public DateTime TimeOfArrivalFormat
        {
            get { return Convert.ToDateTime(TimeOfArrival); }
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