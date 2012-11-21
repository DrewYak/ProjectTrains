using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Xml;

namespace Trains
{
    class Train
    {
        public int _number;
        public int _countOfPas;
        public string _timeOfDeparture;
        public string _timeOfArrival;
        public Route _theRoute;

        public Train(int Number, int CountOfPas, string TimeOfDeparture, string TimeOfArrival)
        {
            this.Number = Number;
            this.CountOfPas = CountOfPas;
            this.TimeOfDeparture = TimeOfDeparture;
            this.TimeOfArrival = TimeOfArrival;
        }

        public static Dictionary<int, Train> AllTrains = new Dictionary<int, Train>();

        /// <summary>
        /// �������� ������� �� ������, ���-�� ����������, ������� ����������� � ��������, ��������.
        /// </summary>
        /// <param name="Number">����� ������.</param>
        /// <param name="CountOfPas">���������� ����������.</param>
        /// <param name="TimeOfDeparture">����� �����������.</param>
        /// <param name="TimeOfArrival">����� ��������.</param>
        /// <param name="TheRoute">�������.</param>
        public Train(int Number, int CountOfPas, string TimeOfDeparture, string TimeOfArrival, Route TheRoute)
        {
            this.Number = Number;
            this.CountOfPas = CountOfPas;
            this.TimeOfDeparture = TimeOfDeparture;
            this.TimeOfArrival = TimeOfArrival;
            this.TheRoute = TheRoute;
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
        ///  ��������� ������ � ����������� ������� AllTrains.
        /// </summary>
        public void Add()
        {
            try
            {
                AllTrains.Add(this.Number, this);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("����� �����", Number, "��� ����������");
            }
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
        /// ���������� ����� �� ������� �� ��� ������.
        /// </summary>
        /// <param name="Number">����� ������</param>
        /// <returns></returns>
        public static Train Search(int Number)
        {
            try
            {
                return AllTrains[Number];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("����� �����", Number, "�� ������");
                return (new Train(0, 0, "b", "c", new Route("������", "����")));
            }

        }

        /// <summary>
        /// ���������� ����� �� ������� �� ������ �����������.
        /// </summary>
        /// <param name="PointsOfDeparture">����� �����������</param>
        /// <returns></returns>
        public static Dictionary<int, Train> SearchByPointsOfDeparture(string PointsOfDeparture)
        {
            Dictionary<int, Train> ResultDictionary = new Dictionary<int, Train>();
            foreach (KeyValuePair<int, Train> kvp in AllTrains)
            {
                //Train Trn = kvp.Value as Train;
                if (PointsOfDeparture == kvp.Value.TheRoute.PointsOfDeparture)
                {
                    ResultDictionary.Add(kvp.Key, kvp.Value);
                }
            }
            return ResultDictionary;
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
        /// ���������� �������.
        /// </summary>
        public Route TheRoute
        {
            get { return _theRoute; }
            set { if (value != null) _theRoute = value; }
        }
    }
}
/*
[TestFixture]

class TrainTest 
{
    [Test]
    public static void firstmethod()
    {
        Train T = new Train(12, 20, "12:30", "15:50");
        Assert.AreEqual(12, T.Number) ;// �����������
        Assert.AreEqual(20, T.CountOfPas);
        Assert.AreEqual("12:30", T.TimeOfDeparture);
        Assert.AreEqual("15:50", T.TimeOfArrival);
    }
}
*/