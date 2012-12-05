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
        List<RoteNode>   _stations;

        /// <summary>
        /// ����������� ������ ���� �������.
        /// </summary>
        static List<Train> AllTrains = new List<Train>();

        /// <summary>
        /// �������������� ����� �� ��� ������ � ������ ������ ������ ���������.
        /// </summary>
        /// <param name="NumberOfTrain"></param>
        public Train(int NumberOfTrain)
        {
            this.Number     = NumberOfTrain;
            this.ListOfPas = new List<int>();
        }

        /// <summary>
        ///  ��������� ������ � ����������� ������� AllTrains.
        /// </summary>
        public void Add()
        {
                AllTrains.Add(this.Number, this);
        }

        /// <summary>
        /// ������� ����� �� ��� ������.
        /// </summary>
        /// <param name="Number">����� ������</param>
        public void Remove(int Number)
        {
            AllTrains.Remove(this.Number);
        }

        /// <summary>
        /// ��������� ��������� � ������.
        /// </summary>
        /// <param name="ID">����� �������� ���������.</param>
        /// <param name="NumberOfTrain">����� ������.</param>
        public static void AddPassengerToTrain(int ID, int NumberOfTrain)
        {
            AllTrains[NumberOfTrain].ListOfPas.Add(ID);
        }

        public static void AddStationToTrain(RoteNode station, int NumberOfTrain)
        {
            if (AllTrains[NumberOfTrain].Stations == null)
            {
                AllTrains[NumberOfTrain].Stations = new List<RoteNode>();
            }
            AllTrains[NumberOfTrain].Stations.Add(station);
        }

        /// <summary>
        /// ���������� ����� �� ������� �� ��� ������.
        /// </summary>
        /// <param name="Number">����� ������</param>
        /// <returns></returns>
        public static Train Search(int Number)
        {
            return AllTrains[Number];
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

                TheTrain.Add();
            }
        }

        /// <summary>
        /// ���������� ������ ����������� �������.
        /// </summary>
        /// <param name="PointOfDep">������� ����� �����������.</param>
        /// <param name="PointOfArr">������� ����� ��������.</param>
        /// <returns></returns>
        public static List<Train> Search(string PointOfDep, string PointOfArr)
        {
            List<Train> Trns    = Train.ConvertToListOfTrn();
            if (PointOfDep.Length != 0)
            {
                Trns    = Train.SearchByDep(PointOfDep, Trns);
            }
            if (PointOfArr.Length != 0)
            {
                Trns    = Train.SearchByArr(PointOfArr, Trns);
            }
            return Trns;
        }

        /// <summary>
        /// ���������� ������ �������, �������������� �� ���������� ������.
        /// </summary>
        /// <param name="PointOfDep">������� ����� �����������.</param>
        /// <param name="Trns">������ �������, � ������� ���������� �����.</param>
        /// <returns></returns>
        private static List<Train> SearchByDep(string PointOfDep, List<Train> Trns)
        {
            List<Train> Result  = new List<Train>();
            foreach(Train Trn in Trns)
            {
                if (Trn.Stations[0]._name == PointOfDep)
                {
                    Result.Add(Trn);
                }
            }
            return Result;
        }

        /// <summary>
        /// ���������� ������ �������, ����������� � ��������� �����.
        /// </summary>
        /// <param name="PointOfArr">������� ����� ��������.</param>
        /// <param name="Trns">������ �������, � ������� ���������� �����.</param>
        /// <returns></returns>
        private static List<Train> SearchByArr(string PointOfArr, List<Train> Trns)
        {
            List<Train> Result  = new List<Train>();
            foreach(Train Trn in Trns)
            {
                // ���, ������ ������, �������!
                if (Trn.Stations[1]._name == PointOfArr)
                {
                    Result.Add(Trn);
                }
            }
            return Result;
        }

        /// <summary>
        /// ���������� ������ ���� �������, ��������� � ���������.
        /// </summary>
        /// <returns></returns>
        private static List<Train> ConvertToListOfTrn()
        {
            List<Train> Result  = new List<Train>();
            foreach(KeyValuePair<int, Train> kvp in AllTrains)
            {
                Result.Add(kvp.Value);
            }
            return Result;
        }



        /// <summary>
        /// ���������� ����� ������.
        /// </summary>
        public int Number
        {
            get { return _number; }
            set { if (value >= 0) _number = value; }
        }

        /// <summary>
        /// ���������� ���������� ����������.
        /// </summary>
        public int CountOfPas
        {
            get { return ListOfPas.Count; }
        }

        /// <summary>
        /// ��������� ����� �����������.
        /// </summary>
        public string TimeOfDeparture
        {
            get { return Stations[0]._timeOfDeparture; }
        }

        /// <summary>
        /// ���������� ����� ��������.
        /// </summary>
        public string TimeOfArrival
        {
            get 
            { 
                int lastIndex   = Stations.Count - 1;
                return Stations[lastIndex]._timeOfArrival;
            }
        }

        /// <summary>
        /// ���������� ������ ���������� � ������.
        /// </summary>
        public List<Passenger>  ListOfPas   { get { return _listOfPas; } } 

        /// <summary>
        /// ���������� � �����
        /// </summary>
        public List<RoteNode>    Stations    { get { return _stations; } }

    }
}

/*
[TestFixture]
class SearchByParams
{
    Data
}
*/