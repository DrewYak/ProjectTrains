using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Xml;

namespace Trains
{

    struct Station
    {
        public string Name;              
        public string TimeOfDeparture;   
        public string TimeOfArrival;     

        public Station(string name, string timeOfDeparture, string timeOfArrival)
        {
            Name            = name;
            TimeOfDeparture = timeOfDeparture;
            TimeOfArrival   = timeOfArrival;
        }
    }

    class Train
    {
        int     _number;
        int     _countOfPas;
        string  _timeOfDeparture;
        string  _timeOfArrival;

        static Dictionary<int, Train> AllTrains = new Dictionary<int, Train>();

        /// <summary>
        /// �������� ������� �� ������, ���-�� ����������, ������� ����������� � ��������, ��������.
        /// </summary>
        /// <param name="Number">����� ������.</param>
        /// <param name="CountOfPas">���������� ����������.</param>
        /// <param name="TimeOfDeparture">����� �����������.</param>
        /// <param name="TimeOfArrival">����� ��������.</param>
        /// <param name="TheRoute">�������.</param>
        public Train(int Number, int CountOfPas, string TimeOfDeparture, string TimeOfArrival)
        {
            this.Number = Number;
            this.CountOfPas = CountOfPas;
            this.TimeOfDeparture = TimeOfDeparture;
            this.TimeOfArrival = TimeOfArrival;
        }

        /// <summary>
        /// �������� ������� ����� 9999
        /// </summary>
        public Train()
        {
            this.Number = 9999;
            this.CountOfPas = 0;
            this.TimeOfDeparture = "06:00";
            this.TimeOfArrival = "13:00";
        }

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

        public static void AddStationToTrain(Station station, int NumberOfTrain)
        {
            if (AllTrains[NumberOfTrain].Stations == null)
            {
                AllTrains[NumberOfTrain].Stations = new List<Station>();
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
                if (Trn.Stations[0].Name == PointOfDep)
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
                if (Trn.Stations[1].Name == PointOfArr)
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
            get { return _countOfPas; }
            set { if (value >= 0) _countOfPas = value; }
        }

        /// <summary>
        /// ��������� ����� �����������.
        /// </summary>
        public string TimeOfDeparture
        {
            get { return _timeOfDeparture; }
            set { if (value.Length >= 0) _timeOfDeparture = value; }
        }

        /// <summary>
        /// ���������� ����� ��������.
        /// </summary>
        public string TimeOfArrival
        {
            get { return _timeOfArrival; }
            set { if (value.Length >= 0) _timeOfArrival = value; }
        }

        /// <summary>
        /// ���������� � ����� ������ ������� ��������� ���������� � ������.
        /// </summary>
        public List<int>        ListOfPas   { get; set; } 

        public List<Station>    Stations    { get; set; }

    }
}

/*
[TestFixture]
class SearchByParams
{
    Data
}
*/