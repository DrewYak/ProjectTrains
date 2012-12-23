using System;
using System.Collections.Generic;
using System.Xml;

namespace Trains
{
    public class Station
    {
        string   _name;
        int      _x;
        int      _y;

        /// <summary>
        /// Список всех станций.
        /// </summary>
        static  List<Station>   _allStations    = new List<Station>();
                List<RouteNode> _routeNodes     = new List<RouteNode>();         

        /// <summary>
        /// Инициализирует станцию по её названию и координатам на форме, 
        /// добавляет (ссылку на) станцию к списку всех станций.
        /// </summary>
        /// <param name="Name">Название станции.</param>
        /// <param name="X">Координата X на форме.</param>
        /// <param name="Y">Координата Y на форме.</param>
        public Station(string Name, int X, int Y)
        {
            _name    = Name;
            _x       = X;
            _y       = Y;
            AddToAllStations();
        }

        /// <summary>
        /// Добавляет узел маршрута к списку узлов маршрута станции.
        /// </summary>
        /// <param name="RouteNode"></param>
        public void AddRouteNode(RouteNode RouteNode)
        {
            this._routeNodes.Add(RouteNode);
        }
        
        public void DEL()
        {
            List<RouteNode> rnds    = this._routeNodes;   
            foreach(RouteNode rnd in rnds)
            {
                rnd.RemoveRNFronTrain();
            }
        }

        /// <summary>
        /// Удаляет узел маршрута из списка узлов маршрута станции.
        /// </summary>
        /// <param name="RouteNode"></param>
        public void RemoveRouteNode(RouteNode RouteNode)
        {

        }

        /// <summary>
        /// Очищает список всех станций.
        /// </summary>
        public static void Unload()
        {
            _allStations.Clear();
        }

        public static void SaveAllStationsToFile(XmlTextWriter xmlOut)
        {
            xmlOut.WriteStartElement("Stations");

            List<Station> stations = Station.Search();
            foreach(Station station in stations)
            {
                station.SaveToFile(xmlOut);
            }

            xmlOut.WriteEndElement();
        }

        public void SaveToFile(XmlTextWriter xmlOut)
        {
            xmlOut.WriteStartElement("Station");
            
            xmlOut.WriteElementString("Name",   this.Name);
            xmlOut.WriteElementString("X",      this.X.ToString());
            xmlOut.WriteElementString("Y",      this.Y.ToString());

            xmlOut.WriteEndElement();
        }

        /// <summary>
        /// Добавляет (ссылку на) станцию к списку всех станций.
        /// </summary>
        private void AddToAllStations()
        {
            _allStations.Add(this);
        }

        /// <summary>
        /// Возвращает истину в случае, если станция с таким названием 
        /// уже добалена к списку всех станций и ложь в противном случае.
        /// </summary>
        /// <param name="StationName"></param>
        /// <returns></returns>
        public static bool Contain(string StationName)
        {
            List<Station> stns = Search();
            foreach(Station stn in stns)
            {
                if (stn.Name == StationName)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Ищет станцию по её названию среди списка всех станций.
        /// В случае успеха возвращает (ссылку на) станцию из списка
        /// всех станций. В случае провала возвращает null.
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static Station SearchByName(string Name)
        {
            foreach (Station Stn in AllStations)
            {
                if (Stn.Name == Name)
                {
                    return Stn;
                }
            }
            return null;
        }

        /// <summary>
        /// Возращает список всех станций.
        /// </summary>
        /// <returns></returns>
        public static List<Station> Search()
        {
            return AllStations;
        }

        /// <summary>
        /// Удаляет себя из списка всех станций.
        /// </summary>
        public void RemoveFromAllStations()
        {
            List<RouteNode> rnds = this.RouteNodes;
            foreach (RouteNode rnd in rnds)
            {
                rnd.RemoveRNFronTrain();
            }
            _allStations.Remove(this);
        }



        /// <summary>
        /// Возвращает название станции.
        /// </summary>
        public string Name { get { return _name; } }     

        /// <summary>
        /// Возвращает координату X станции на форме.
        /// </summary>
        public int X { get { return _x; } }

        /// <summary>
        /// Возвращает координату Y станции на форме.
        /// </summary>
        public int Y { get { return _y; } }

        /// <summary>
        /// Возвращает список всех станций.
        /// </summary>
        static List<Station> AllStations { get { return _allStations; } }

        /// <summary>
        /// Список узлов маршрута, пркреплённых к данной станции.
        /// </summary>
        private List<RouteNode> RouteNodes { get { return _routeNodes; } }
    }
}