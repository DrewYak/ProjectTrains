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
            this.Number         = NumberOfTrain;
            this._tickets       = new List<Ticket>();
            this._routenodes    = new List<RouteNode>();
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
        /// Устанавливает ссылку на билет. Добавляет билет 
        /// в список билетов поезда.
        /// </summary>
        /// <param name="Ticket"></param>
        public void AddTicket(Ticket Ticket)
        {
            this._tickets.Add(Ticket);
        }

        /// <summary>
        /// Добавляет узел маршрута в конец маршрута поезда.
        /// </summary>
        /// <param name="RouteNode"></param>
        public void AddRouteNode(RouteNode RouteNode)
        {
            this._routenodes.Add(RouteNode);
            RouteNodeComparer rnc = new RouteNodeComparer();
            this._routenodes.Sort(rnc);
        }

        /// <summary>
        /// Ищет станцию из маршрута поезда по времени отправления/прибытия.
        /// </summary>
        /// <param name="time">Время отправления или время прибытия.</param>
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
        /// Возвращает индекс станции в маршруте поезда (начиная с 0) по 
        /// её названию. В случае, если такой станции нет в маршруте поезда,
        /// возвращает -1.
        /// </summary>
        /// <param name="StationName"></param>
        /// <returns></returns>
        private int IndexStation(String StationName)
        {
            List<RouteNode> rns = this.RouteNodes;
            foreach(RouteNode rn in rns)
            {
                if (rn.Station.Name == StationName)
                {
                    return rns.IndexOf(rn);
                }
            }
            return -1;
        }

        /// <summary>
        /// Возвращает ближайшую станцию, на которую приедет поезд.
        /// В случае, когда введённое время превосходит время прибытия
        /// поезда, возвращает null.
        /// </summary>
        /// <param name="Time">Время.</param>
        /// <returns></returns>
        private RouteNode NextRouteNode(DateTime Time)
        {
            List<RouteNode> rns = this.RouteNodes;
            foreach(RouteNode rn in rns)
            {
                if (rn.TimeOfArrivalFormat >= Time)
                {
                    return rn;
                }
            }
            return null;
        }

        /// <summary>
        /// Возвращает ближайшую станцию, которую поезд уже покинул.
        /// В случае, когда введённое время меньше времени отправления
        /// поезда, возвращает null.
        /// </summary>
        /// <param name="Time">Время.</param>
        /// <returns></returns>
        private RouteNode PrevRouteNode(DateTime Time)
        {
            List<RouteNode> rns                 = this.RouteNodes;
            String          StationName         = this.NextRouteNode(Time).Station.Name;
            int             IndexPrevStation    = this.IndexStation(StationName) - 1;
            if (IndexPrevStation >= 0)
            {
                return rns[IndexPrevStation];
            }
            else
            {
                return null;
            }

        }

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
        /// Возвращает местоположение поезда в заданнный момент времени.
        /// </summary>
        /// <param name="Time">Заданный момент времени.</param>
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
        /// список ревалентных поездов. В случае провала возвращает null.
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
        /// список ревалентных поездов. В случае провала возвращает null.
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
            get { return Tickets.Count; }
        }

        /// <summary>
        /// Возвращает название начальной станции.
        /// </summary>
        public string PointOfDeparture
        {
            get { return RouteNodes[0].Station.Name; }
        }

        /// <summary>
        /// Возвращает название конечной станции.
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
        /// Возвращает время отправления поезда с начальной станции.
        /// </summary>
        public string TimeOfDeparture
        {
            get { return RouteNodes[0].TimeOfDeparture; }
        }

        /// <summary>
        /// Возврашает время прибытия поезда на конечную станцию.
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
        /// Возвращает список билетов поезда.
        /// </summary>
        public List<Ticket>  Tickets   { get { return _tickets; } } 

        /// <summary>
        /// Возвращает список узлов маршрута, через которые проходит поезд.
        /// </summary>
        public List<RouteNode>   RouteNodes    { get { return _routenodes; } }

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