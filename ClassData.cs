using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Trains
{


    class Data
    {

        /// <summary>
        /// Загружает все данные из XML-документа в оперативную память для дальнейшей работы.
        /// </summary>
        /// <param name="FileName">Путь к XML-документу.</param>
        public static void LoadFromFile(string FileName)
        {
            XmlDocument doc         = new XmlDocument();
            doc.Load(FileName);
            
            XmlNode     root        = doc.DocumentElement;
            XmlNodeList stations    = root.ChildNodes[0].ChildNodes;
            XmlNodeList trains      = root.ChildNodes[1].ChildNodes;

            LoadStations (stations);
            LoadTrains   (trains);
        }


        /// <summary>
        /// Добавляет данные о местоположениях станций в программу.
        /// </summary>
        /// <param name="Stations">Список узлов типа Location.</param>
        private static void LoadStations(XmlNodeList Stations)
        {
            foreach(XmlNode Stn in Stations)
            {
                string  name    = Stn.ChildNodes[0].InnerText;
                int     x       = Convert.ToInt32(Stn.ChildNodes[1].InnerText);
                int     y       = Convert.ToInt32(Stn.ChildNodes[2].InnerText);

                Station Station = new Station(name, x, y);
//                Station.AddToAllStations();
            }
        }

        /// <summary>
        /// Добавляет данные о поездах в оперативную память.
        /// </summary>
        /// <param name="Trains">Список узлов типа Train.</param>
        private static void LoadTrains(XmlNodeList Trains)
        {
            foreach(XmlNode Trn in Trains)
            {
                int         Number      = Convert.ToInt32(Trn.ChildNodes[0].InnerText);
                XmlNodeList RouteNodes  = Trn.ChildNodes[1].ChildNodes;
                XmlNodeList Passengers  = Trn.ChildNodes[2].ChildNodes;

                Train Train = new Train(Number);

                LoadRouteNodes   (Train, RouteNodes);
                LoadPassengers   (Train, Passengers);
            }
        }

        /// <summary>
        /// Добавляет данные о станциях в оперативную память и
        /// добавляет станции к маршруту поезда.
        /// </summary>
        /// <param name="NumberOfTrain">Номер поезда.</param>
        /// <param name="RouteNodes">Список узлов типа Station.</param>
        private static void LoadRouteNodes(Train Train, XmlNodeList RouteNodes)
        {
            foreach(XmlNode RouteNode in RouteNodes)
            {
                string      name            = RouteNode.ChildNodes[0].InnerText;
                string      timeOfDeparture = RouteNode.ChildNodes[1].InnerText;
                string      timeOfArrival   = RouteNode.ChildNodes[2].InnerText;
                Station     station         = Station.SearchByName(name);
                RouteNode    routenode       = new RouteNode(station, timeOfDeparture, timeOfArrival);
                Train.AddRouteNode(routenode);     
            }
        }

        /// <summary>
        /// Добавляет данные о пассажирах в программу и устанавливает связь 
        /// между поездами и пассажирами.
        /// </summary>
        /// <param name="Train">Поезд, в который добавляюся пассажиры из списка узлов.</param>
        /// <param name="Passengers">Список узлов типа Passenger.</param>
        private static void LoadPassengers(Train Train, XmlNodeList Passengers)
        {
            foreach(XmlNode Psg in Passengers)
            {
                int         ID              = Convert.ToInt32(Psg.ChildNodes[0].InnerText);
                Passenger   PAS             = Passenger.Search(ID);
                string      TypeOfTicket    = Psg.ChildNodes[3].InnerText;

                if (PAS != null)
                {
                    Ticket  Ticket  = new Ticket(Train, TypeOfTicket, PAS);
                }
                else
                {
                    string  LName   = Psg.ChildNodes[1].InnerText;
                    string  FName   = Psg.ChildNodes[2].InnerText;
                    PAS             = new Passenger(ID, FName, LName);
                    Ticket  Ticket  = new Ticket(Train, TypeOfTicket, PAS);
                }
            }
        }
    }
}
