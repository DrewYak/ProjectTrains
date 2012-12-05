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
        /// Инициализирует узел маршрута по станции, времени прибытия
        /// на эту станцию и времени отправления с этой станции.
        /// </summary>
        /// <param name="TheStation">Станция узла маршрута.</param>
        /// <param name="TimeOfArrival">Время прибытия поезда на станцию.</param>
        /// <param name="TimeOfDeparture">Время отправления поезда со станции.</param>
        public RoteNode(Station TheStation, string TimeOfArrival, string TimeOfDeparture)
        {
            _theStation         = TheStation;     
            _timeOfArrival      = TimeOfArrival;
            _timeOfDeparture    = TimeOfDeparture;
        }

        /// <summary>
        /// Возвращает станцию узла маршрута.
        /// </summary>
        public Station TheStation { get { return _theStation; } }

        /// <summary>
        /// Возвращает время прибытия поезда на станцию.
        /// </summary>
        public string TimeOfArrival { get { return _timeOfArrival; } }

        /// <summary>
        /// Возвращает время отпрвления поезда со станции.
        /// </summary>
        public string TimeOfDeparture { get { return _timeOfDeparture; } }
    }

    class Train
    {
        int             _number;
        List<Passenger> _listOfPas;
        List<RoteNode>   _stations;

        /// <summary>
        /// Статический список всех поездов.
        /// </summary>
        static List<Train> AllTrains = new List<Train>();

        /// <summary>
        /// Инициализирует поезд по его номеру и создаёт пустой список пассажров.
        /// </summary>
        /// <param name="NumberOfTrain"></param>
        public Train(int NumberOfTrain)
        {
            this.Number     = NumberOfTrain;
            this.ListOfPas = new List<int>();
        }

        /// <summary>
        ///  Добавляет поезда в статический словарь AllTrains.
        /// </summary>
        public void Add()
        {
                AllTrains.Add(this.Number, this);
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
        /// Добавляет пассажира к поезду.
        /// </summary>
        /// <param name="ID">Номер паспорта пассажира.</param>
        /// <param name="NumberOfTrain">Номер поезда.</param>
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
        /// Возвращает поезд из словаря по его номеру.
        /// </summary>
        /// <param name="Number">Номер поезда</param>
        /// <returns></returns>
        public static Train Search(int Number)
        {
            return AllTrains[Number];
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
        /// Возвращает список ревалентных поездов.
        /// </summary>
        /// <param name="PointOfDep">Искомый пункт отправления.</param>
        /// <param name="PointOfArr">Искомый пункт прибытия.</param>
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
        /// Возвращает список поездов, отправляющихся из указанного пункта.
        /// </summary>
        /// <param name="PointOfDep">Искомый пункт отправления.</param>
        /// <param name="Trns">Список поездов, в котором проводится поиск.</param>
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
        /// Возвращает список поездов, прибывающих в указанный пункт.
        /// </summary>
        /// <param name="PointOfArr">Искомый пункт прибытия.</param>
        /// <param name="Trns">Список поездов, в котором проводится поиск.</param>
        /// <returns></returns>
        private static List<Train> SearchByArr(string PointOfArr, List<Train> Trns)
        {
            List<Train> Result  = new List<Train>();
            foreach(Train Trn in Trns)
            {
                // Тут, вообще говоря, неверно!
                if (Trn.Stations[1]._name == PointOfArr)
                {
                    Result.Add(Trn);
                }
            }
            return Result;
        }

        /// <summary>
        /// Возвращает список всех поездов, имеющихся в программе.
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
            get { return ListOfPas.Count; }
        }

        /// <summary>
        /// Возвраает время отправления.
        /// </summary>
        public string TimeOfDeparture
        {
            get { return Stations[0]._timeOfDeparture; }
        }

        /// <summary>
        /// Возврашает время прибытия.
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
        /// Возвращает список пассажиров в поезде.
        /// </summary>
        public List<Passenger>  ListOfPas   { get { return _listOfPas; } } 

        /// <summary>
        /// Возвращает и задаёт
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