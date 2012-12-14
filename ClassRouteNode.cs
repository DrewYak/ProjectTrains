﻿
namespace Trains
{
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
    }
}