using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trains
{
    class List
    {
        public static List<Passenger> _allPassengers;
 
        /// <summary>
        /// Очищает список всех пассажиров.
        /// </summary>
        public static void Unload()
        {
            _allPassengers.Clear();
        }

        /// <summary>
        /// Добавляет пассажира в список всех пассажиров.
        /// </summary>
        public static void AddToAllPassengers(Passenger passenger)
        {
            _allPassengers.Add(passenger);
        }
        
        /// <summary>
        /// Удаляет пассажира из списка всех пассажиров.
        /// </summary>
        public static void RemoveFromAllPassengers(Passenger passenger)
        {
            List<Ticket> tkts = passenger._tickets;
            foreach (Ticket tkt in tkts)
            {
                // Удалить 1
                tkt.Train.RemoveTicket(tkt);
            }
            // Удалить 2
            passenger._tickets.Clear();
            // Удалить 3
            _allPassengers.Remove(passenger);
        }

    }
}
