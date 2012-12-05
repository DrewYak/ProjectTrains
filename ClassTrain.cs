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
        List<RoteNode>  _route;

        /// <summary>
        /// Статический список всех поездов.
        /// </summary>
        static List<Train> _allTrains = new List<Train>();

        /// <summary>
        /// Инициализирует поезд по его номеру, создаёт пустой список пассажиров
        /// и добавляет поезд к списку всех поездов.
        /// </summary>
        /// <param name="NumberOfTrain">Номер поезда.</param>
        public Train(int NumberOfTrain)
        {
            this.Number     = NumberOfTrain;
            this._listOfPas = new List<Passenger>();
            AddToAllTrains();
        }

        /// <summary>
        ///  Добавляет поезд в список всех поездов.
        /// </summary>
        private void AddToAllTrains()
        {
                _allTrains.Add(this);
        }

        /// <summary>
        /// Удаляет поезд из списка всех поездов.
        /// </summary>
        public void RemoveFromAllTrains()
        {
            _allTrains.Remove(this);
        }

        /// <summary>
        /// Добавляет пассажира к поезду.
        /// </summary>
        /// <param name="ID">Номер паспорта пассажира.</param>
        /// <param name="NumberOfTrain">Номер поезда.</param>
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

                TheTrain.AddToAllTrains();
            }
        }

        #region Поиск и связанные с ним методы

        /// <summary>
        /// Ищет поезд по его номеру. В случае успешного поиска возвращает
        /// поезд. В случае провала возвращает null.
        /// </summary>
        /// <param name="Number">Номер поезда</param>
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
        /// Ищет поезда по начальной и конечной станциям. В случае успеха возвращает
        /// список релевантных поездов. В случае провала возвращает null.
        /// </summary>
        /// <param name="PointOfDep">Искомая начальная станция.</param>
        /// <param name="PointOfArr">Искомая конечная станция.</param>
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
        /// Ищет поезда по начальной станции. В случае успеха возвращает
        /// список релевантных поездов. В случае провала возвращает null.
        /// </summary>
        /// <param name="PointOfArr">Конечная станция.</param>
        /// <param name="Trns">Список поездов, в котором проводится поиск.</param>
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
        /// Ищет поезда по конечной станции. В случае успеха возвращает
        /// список релевантных поездов. В случае провала возвращает null.
        /// </summary>
        /// <param name="PointOfArr">Конечная станция.</param>
        /// <param name="Trns">Список поездов, в котором проводится поиск.</param>
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

        #region Свойства

        /// <summary>
        /// Возвращает номер поезда.
        /// </summary>
        public int Number
        {
            get { return _number; }
            set { if (value >= 0) _number = value; }
        }

        /// <summary>
        /// Возвращает фактическое количество пассажиров в поезде.
        /// </summary>
        public int CountOfPas
        {
            get { return ListOfPas.Count; }
        }

        /// <summary>
        /// Возвращает название начальной станции.
        /// </summary>
        public string PointOfDeparture
        {
            get { return Route[0].TheStation.Name; }
        }

        /// <summary>
        /// Возвращает название конечной станции.
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
        /// Возвращает время отправления поезда с начальной станции.
        /// </summary>
        public string TimeOfDeparture
        {
            get { return Route[0].TimeOfDeparture; }
        }

        /// <summary>
        /// Возврашает время прибытия поезда.
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
        /// Возвращает список пассажиров в поезде.
        /// </summary>
        public List<Passenger>  ListOfPas   { get { return _listOfPas; } } 

        /// <summary>
        /// Возвращает список узлов маршрута, через которые проходит поезд.
        /// </summary>
        public List<RoteNode>   Route    { get { return _route; } }

        /// <summary>
        /// Возвращает список всех поездов.
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