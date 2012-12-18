namespace Trains
{
    public class Ticket
    {
        /// <summary>
        /// Поезд, в котором едет пассажир по данному билету.
        /// </summary>
        Train    _train;
     
        /// <summary>
        /// Тип вагона.
        /// </summary>
        string   _type;

        /// <summary>
        /// Пассажир, владелец билета.
        /// </summary>
        Passenger _passenger;

        /// <summary>
        /// Инициализирует билет по поезду, в котором едет пассажир, типу вагона и
        /// пассажиру, который едет по этому билету. Устанавливает ссылки от себя 
        /// на поезд и на пассажира, а также  ссылки от поезда и от пассажира на себя.
        /// </summary>
        /// <param name="Train">Поезд, в котором едет пассажир.</param>
        /// <param name="Type">Тип вагона.</param>
        public Ticket(Train Train, string Type, Passenger Passenger)
        {
            _train      = Train;
            _type       = Type;
            _passenger  = Passenger;
            Associate(Train, Passenger);
        }

        /// <summary>
        /// Устанавливает ссылки от поезда и от пассажира на себя.
        /// </summary>
        /// <param name="Train"></param>
        /// <param name="Passenger"></param>
        private void Associate(Train Train, Passenger Passenger)
        {
            Train.      AddTicket(this);
            Passenger.  AddTicket(this);
        }

        /// <summary>
        /// Поезд, в котором едет пассажир по данному билету.
        /// </summary>
        public Train        Train       { get { return _train;      } }

        /// <summary>
        /// Тип вагона, в котором едет пассажир по данному билету.
        /// </summary>
        public string       Type        { get { return _type ;      } }

        /// <summary>
        /// Пассажир, на которого оформлен данный билет.
        /// </summary>
        public Passenger    Passenger   { get { return _passenger;  } }
    }
}