using System;
using System.Collections.Generic;
using System.Xml;

namespace Trains
{
    public class RouteNodeComparer : IComparer<RouteNode>
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
    public class RouteNode 
    {
        Station _station;
        Train   _train;
        string  _timeOfArrival;     
        string  _timeOfDeparture;  

        /// <summary>
        /// Инициализирует узел маршрута по станции, времени прибытия поезда
        /// на эту станцию и времени отправления поезда с этой станции.
        /// </summary>
        /// <param name="Station">Станция узла маршрута.</param>
        /// <param name="TimeOfArrival">Время прибытия поезда на станцию.</param>
        /// <param name="TimeOfDeparture">Время отправления поезда со станции.</param>
        public RouteNode(Station Station, string TimeOfArrival, string TimeOfDeparture, Train Train)
        {
            // Устанавливаем ссылку от RouteNode к Station.
            _station            = Station;
            // Устанавливаем ссылку от RouteNode к Train.
            _train              = Train;
            _timeOfArrival      = TimeOfArrival;
            _timeOfDeparture    = TimeOfDeparture;
            // Устанавливаем ссылку от Station к RouteNode.
            Station.AddRouteNode(this);
            // Устанавливаем ссылку от Train к RouteNode.
            Train.  AddRouteNode(this);
        }

        /// <summary>
        /// Удаляет узел маршрута из маршрута поезда.
        /// </summary>
        public void RemoveRNFronTrain()
        {
            _train.RouteNodes.Remove(this);
        }

        public static void SaveRouteNodesToFile(XmlTextWriter xmlOut, Train train)
        {
            xmlOut.WriteStartElement("RoteNodes");

            List<RouteNode> routenodes = train.RouteNodes;
            foreach(RouteNode routenode in routenodes)
            {
                routenode.SaveToFile(xmlOut);
            }

            xmlOut.WriteEndElement();
        }

        public void SaveToFile(XmlTextWriter xmlOut)
        {
            xmlOut.WriteStartElement("RouteNode");

            xmlOut.WriteElementString("Station",    this.Station.Name);
            xmlOut.WriteElementString("Arrive",     this.TimeOfArrival);
            xmlOut.WriteElementString("Depart",     this.TimeOfDeparture);

            xmlOut.WriteEndElement();
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