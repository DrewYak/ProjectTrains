using System;
using System.Collections.Generic;

namespace Trains
{
    class Station
    {
        string   _name;
        int      _x;
        int      _y;
        static List<Station> _allStations = new List<Station>();

        /// <summary>
        /// инициализирует станцию по её названию и координатам на форме.
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
        /// Добавляет местоположение станции в оперативную память
        /// для дальнейшей работы.
        /// </summary>
        /// <param name="Station">Местоположение станции.</param>
        private void AddToAllStations()
        {
            _allStations.Add(this);
        }

        public static Station Search(string Name)
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
        static List<Station> AllStations { get { return _allStations; } }
    }
}