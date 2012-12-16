using System;
using System.Collections.Generic;


namespace Trains
{
    class RouteNodeComparer : IComparer<RouteNode>
    {
        public int Compare(RouteNode RN1, RouteNode RN2)
        {
            if (RN1.TimeOfArrivalFormat == RN2.TimeOfArrivalFormat)
            { return  0; }
            if (RN1.TimeOfArrivalFormat > RN2.TimeOfArrivalFormat)
            { return  1; }
            else
            { return -1; }
        }
    }
    class RouteNode 
    {
        Station _station;
        string  _timeOfArrival;     
        string  _timeOfDeparture;   

        /// <summary>
        /// Инициализирует узел маршрута по станции, времени прибытия поезда
        /// на эту станцию и времени отправления поезда с этой станции.
        /// </summary>
        /// <param name="Station">Станция узла маршрута.</param>
        /// <param name="TimeOfArrival">Время прибытия поезда на станцию.</param>
        /// <param name="TimeOfDeparture">Время отправления поезда со станции.</param>
        public RouteNode(Station Station, string TimeOfArrival, string TimeOfDeparture)
        {
            _station            = Station;     
            _timeOfArrival      = TimeOfArrival;
            _timeOfDeparture    = TimeOfDeparture;
        }

        /// <summary>
        /// Возвращает станцию узла маршрута.
        /// </summary>
        public Station Station { get { return _station; } }

        /// <summary>
        /// Возвращает время прибытия поезда на станцию.
        /// </summary>
        public string TimeOfArrival { get { return _timeOfArrival; } }

        /// <summary>
        /// Возвращает время отпрвления поезда со станции.
        /// </summary>
        public string TimeOfDeparture { get { return _timeOfDeparture; } }

        /// <summary>
        /// Возвращает время прибытия поезда на станцию в форматe DateTime.
        /// </summary>
        public DateTime TimeOfArrivalFormat { get { return DateTime.Parse(_timeOfArrival); } }

        /// <summary>
        /// Возвращает время отпрвления поезда со станции в форматe DateTime.
        /// </summary>
        public DateTime TimeOfDepartureFormat { get { return DateTime.Parse(_timeOfDeparture); } }
    }
}