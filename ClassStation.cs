using System;
using System.Collections.Generic;

namespace Trains
{
    class Station
    {
        string   _name;
        int      _x;
        int      _y;

        /// <summary>
        /// Список всех станций.
        /// </summary>
        static List<Station> _allStations = new List<Station>();

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
        /// Добавляет (ссылку на) станцию к списку всех станций.
        /// </summary>
        private void AddToAllStations()
        {
            _allStations.Add(this);
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
    }
}