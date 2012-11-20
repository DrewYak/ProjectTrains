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

        public static Dictionary<int, Train> AllTrains = new Dictionary<int, Train>();

        /// <summary>
        /// Создание объекта по номеру, кол-ву пассажиров, времени отправления и прибытия, маршруту.
        /// </summary>
        /// <param name="Number">Номер поезда.</param>
        /// <param name="CountOfPas">Количество пассажиров.</param>
        /// <param name="TimeOfDeparture">Время отправления.</param>
        /// <param name="TimeOfArrival">Время прибытия.</param>
        /// <param name="TheRoute">Маршрут.</param>
        public Train(int Number, int CountOfPas, string TimeOfDeparture, string TimeOfArrival, Route TheRoute)
        {
            this.Number = Number;
            this.CountOfPas = CountOfPas;
            this.TimeOfDeparture = TimeOfDeparture;
            this.TimeOfArrival = TimeOfArrival;
            this.TheRoute = TheRoute;
        }

        /// <summary>
        /// Создание объекта номер 9999
        /// </summary>
        public Train()
        {
            this.Number = 9999;
            this.CountOfPas = 0;
            this.TimeOfDeparture = "06:00";
            this.TimeOfArrival = "13:00";
        }

        /// <summary>
        ///  Добавляет поезда в статический словарь AllTrains.
        /// </summary>
        public void Add()
        {
            try
            {
                AllTrains.Add(this.Number, this);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Поезд номер", Number, "уже существует");
            }
        }
        /// <summary>
        /// Удаляет поезд по его номеру.
        /// </summary>
        /// <param name="Number">Номер поезда</param>
        public void Remove(int Number)
        {
            AllTrains.Remove(this.Number);
        }

        /// <summary>
        /// Возвращает поезд из словаря по его номеру.
        /// </summary>
        /// <param name="Number">Номер поезда</param>
        /// <returns></returns>
        public static Train Search(int Number)
        {
            try
            {
                return AllTrains[Number];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Поезд номер", Number, "не найден");
                return (new Train(0, 0, "b", "c", new Route("Москва", "Сочи")));
            }

        }

        /// <summary>
        /// Возвращает поезд из словаря по пункту отправления.
        /// </summary>
        /// <param name="PointsOfDeparture">Пункт отправления</param>
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
        /// Добавляет данные из XML-файла в статический словарь AllTrains класса Train.
        /// </summary>
        /// <param name="FileName">Путь к XML-файлу</param>
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
        /// Возвращает номер поезда.
        /// </summary>
        public int Number
        {
            get { return _number; }
            set { if (value >= 0) _number = value; }
        }

        /// <summary>
        /// Возвращает количество пассажиров.
        /// </summary>
        public int CountOfPas
        {
            get { return _countOfPas; }
            set { if (value >= 0) _countOfPas = value; }
        }

        /// <summary>
        /// Возвраает время отправления.
        /// </summary>
        public string TimeOfDeparture
        {
            get { return _timeOfDeparture; }
            set { if (value.Length >= 0) _timeOfDeparture = value; }
        }

        /// <summary>
        /// Возврашает время прибытия.
        /// </summary>
        public string TimeOfArrival
        {
            get { return _timeOfArrival; }
            set { if (value.Length >= 0) _timeOfArrival = value; }
        }

        /// <summary>
        /// Возвращает маршрут.
        /// </summary>
        public Route TheRoute
        {
            get { return _theRoute; }
            set { if (value != null) _theRoute = value; }
        }
    }

}