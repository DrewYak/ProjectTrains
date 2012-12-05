using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Xml;

namespace Trains
{

    struct RoteNode
    {
        Station _theStation;
        string  _timeOfArrival;     
        string  _timeOfDeparture;   

        /// <summary>
        /// �������������� ���� �������� �� �������, ������� ��������
        /// �� ��� ������� � ������� ����������� � ���� �������.
        /// </summary>
        /// <param name="TheStation">������� ���� ��������.</param>
        /// <param name="TimeOfArrival">����� �������� ������ �� �������.</param>
        /// <param name="TimeOfDeparture">����� ����������� ������ �� �������.</param>
        public RoteNode(Station TheStation, string TimeOfArrival, string TimeOfDeparture)
        {
            _theStation         = TheStation;     
            _timeOfArrival      = TimeOfArrival;
            _timeOfDeparture    = TimeOfDeparture;
        }

        /// <summary>
        /// ���������� ������� ���� ��������.
        /// </summary>
        public Station TheStation { get { return _theStation; } }

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
        public static void AddPassengerToTrain(int ID, int NumberOfTrain)
        {
            _allTrains[NumberOfTrain].ListOfPas.Add(ID);
        }

        public static void AddStationToTrain(RoteNode station, int NumberOfTrain)
        {
            if (_allTrains[NumberOfTrain].Route == null)
            {
                _allTrains[NumberOfTrain].Route = new List<RoteNode>();
            }
            _allTrains[NumberOfTrain].Route.Add(station);
        }

        /// <summary>
        /// ��������� ������ �� XML-����� � ����������� ������� AllTrains ������ Train.
        /// </summary>
        /// <param name="FileName">���� � XML-�����</param>
        public static void AddDataFromFile(string FileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FileName);

            XmlNodeList Trns = doc.GetElementsByTagName("Train");

            for (int i = 0; i < Trns.Count; i++)
            {
                Train TheTrain = new Train();

                TheTrain.Number = Convert.ToInt32(Trns[i].FirstChild.InnerText);
                TheTrain.TimeOfDeparture = Trns[i].FirstChild.NextSibling.InnerText;
                TheTrain.TimeOfArrival = Trns[i].FirstChild.NextSibling.NextSibling.InnerText;

                TheTrain.AddToAllTrains();
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
            get { return ListOfPas.Count; }
        }

        /// <summary>
        /// ���������� �������� ��������� �������.
        /// </summary>
        public string PointOfDeparture
        {
            get { return Route[0].TheStation.Name; }
        }

        /// <summary>
        /// ���������� �������� �������� �������.
        /// </summary>
        public string PointOfArrival
        {
            get
            {
                int lastIndex = Route.Count - 1;
                return Route[lastIndex].TheStation.Name; 
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