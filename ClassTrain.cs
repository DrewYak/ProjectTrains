using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Xml;

namespace Trains
{

    struct RoteNode
    {
        Station _station;
        string  _timeOfArrival;     
        string  _timeOfDeparture;   

        /// <summary>
        /// �������������� ���� �������� �� �������, ������� ��������
        /// �� ��� ������� � ������� ����������� � ���� �������.
        /// </summary>
        /// <param name="Station">������� ���� ��������.</param>
        /// <param name="TimeOfArrival">����� �������� ������ �� �������.</param>
        /// <param name="TimeOfDeparture">����� ����������� ������ �� �������.</param>
        public RoteNode(Station Station, string TimeOfArrival, string TimeOfDeparture)
        {
            _station            = Station;     
            _timeOfArrival      = TimeOfArrival;
            _timeOfDeparture    = TimeOfDeparture;
        }

        /// <summary>
        /// ���������� ������� ���� ��������.
        /// </summary>
        public Station Station { get { return _station; } }

        /// <summary>
        /// ���������� ����� �������� ������ �� �������.
        /// </summary>
        public string TimeOfArrival { get { return _timeOfArrival; } }

        /// <summary>
        /// ���������� ����� ���������� ������ �� �������.
        /// </summary>
        public string TimeOfDeparture { get { return _timeOfDeparture; } }
    }

    class Train
    {
        int             _number;
        List<Passenger> _listOfPas;
        List<RoteNode>  _route;

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
            this.Number     = NumberOfTrain;
            this._listOfPas = new List<Passenger>();
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
        /// ��������� ��������� � ������.
        /// </summary>
        /// <param name="ID">����� �������� ���������.</param>
        /// <param name="NumberOfTrain">����� ������.</param>
        public static void AddPassengerToTrain(Passenger Passenger, Train Train)
        {
            Train._listOfPas.Add(Passenger);
        }

        public static void AddStationToTrain(RoteNode station, Train Train)
        {
        // 
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
            get { return ListOfPas.Count; }
        }

        /// <summary>
        /// ���������� �������� ��������� �������.
        /// </summary>
        public string PointOfDeparture
        {
            get { return Route[0].Station.Name; }
        }

        /// <summary>
        /// ���������� �������� �������� �������.
        /// </summary>
        public string PointOfArrival
        {
            get
            {
                int lastIndex = Route.Count - 1;
                return Route[lastIndex].Station.Name; 
            }
        }

        /// <summary>
        /// ���������� ����� ����������� ������ � ��������� �������.
        /// </summary>
        public string TimeOfDeparture
        {
            get { return Route[0].TimeOfDeparture; }
        }

        /// <summary>
        /// ���������� ����� �������� ������.
        /// </summary>
        public string TimeOfArrival
        {
            get 
            { 
                int lastIndex   = Route.Count - 1;
                return Route[lastIndex].TimeOfArrival;
            }
        }

        /// <summary>
        /// ���������� ������ ���������� � ������.
        /// </summary>
        public List<Passenger>  ListOfPas   { get { return _listOfPas; } } 

        /// <summary>
        /// ���������� ������ ����� ��������, ����� ������� �������� �����.
        /// </summary>
        public List<RoteNode>   Route    { get { return _route; } }

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