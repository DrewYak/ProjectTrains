using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Xml;

namespace Trains
{
    class Ticket
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
        /// Инициализирует билет по поезду, в котором едет пассажир и типу вагона.
        /// </summary>
        /// <param name="Train">Поезд, в котором едет пассажир.</param>
        /// <param name="Type">Тип вагона.</param>
        public Ticket(Train Train, string Type, Passenger Passenger)
        {
            _train      = Train;
            _type       = Type;
            _passenger  = Passenger;
        }

        public void Associate(Train Train, Passenger Passenger)
        {
            Train.      AddTicket(this);
            Passenger.  AddTicket(this);
        }


        public Train        Train       { get { return _train;      } }
        public string       Type        { get { return _type ;      } }
        public Passenger    Passenger   { get { return _passenger;  } }
    }

    class Passenger
    {
        int             _id;
        string          _firstName;
        string          _lastName;
        List<Ticket>    _tickets;

        /// <summary>
        /// Статический список всех пассажиров.
        /// </summary>
        static List<Passenger> _allPassengers = new List<Passenger>();

        /// <summary>
        /// Инициализирует пассажира по номеру паспорта, имени, фамилии и билету.
        /// Добавляет пассажира в список всех пассажиров.
        /// </summary>
        /// <param name="ID">Номер паспорта.</param>
        /// <param name="FirstName">Имя.</param>
        /// <param name="LastName">Фамилия.</param>
        /// <param name="TheTicket">Билет.</param>
        public Passenger(int ID, string FirstName, string LastName, Ticket TheTicket)
        {
            this.ID         = ID;
            this.FirstName  = FirstName;
            this.LastName   = LastName;
            this._tickets   = new List<Ticket>();
            this._tickets.Add(TheTicket);
            this.AddToAllPassengers();
        }

        /// <summary>
        /// Инициализирует пассажира по номеру паспорта, имени, фамилии.
        /// Добавляет пассажира в список всех пассажиров.
        /// </summary>
        /// <param name="ID">Номер паспорта.</param>
        /// <param name="FirstName">Имя.</param>
        /// <param name="LastName">Фамилия.</param>
        public Passenger(int ID, string FirstName, string LastName)
        {
            this.ID         = ID;
            this.FirstName  = FirstName;
            this.LastName   = LastName;
            this._tickets   = new List<Ticket>();
            this.AddToAllPassengers();
        }

        /// <summary>
        /// Добавляет пассажира в список всех пассажиров.
        /// </summary>
        private void AddToAllPassengers()
        {
            _allPassengers.Add(this);
        }

        /// <summary>
        /// Возвращает истину, если пассажир с данным номером
        /// паспорта уже содерижится в списке всех пассажиров
        /// и ложь, если его там нет.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static bool Contain(int ID)
        {
            if (Passenger.Search(ID) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Удаляет пассажира из списка всех пассажиров.
        /// </summary>
        public void RemoveFromAllPassengers()
        {
            _allPassengers.Remove(this);
        }

        /// <summary>
        /// Добавляет новый билет к уже имеющимся билетам пассажира.
        /// </summary>
        /// <param name="Passenger">Пассажир, к билетам которого добавляем ещё один новый билет.</param>
        /// <param name="Ticket">Новый добавляемый билет.</param>
        public void AddTicket(Ticket Ticket)
        {
            this._tickets.Add(Ticket);
        }

        /// <summary>
        /// Добавляем новый билет к билетам пассажира,
        /// номер паспорта которого введён.
        /// </summary>
        /// <param name="ID">Номер паспорта пассажира.</param>
        /// <param name="Ticket">Новый добавляемый билет пассажира.</param>
        public static void AddTicketToPassengerByID(int ID, Ticket Ticket)
        {
            Passenger Psg   = Search(ID);
            Psg.AddTicket(Ticket);
        }

        #region Поиск и связанные с ним методы

        /// <summary>
        /// Ищет пассажира по номеру паспорта. В случае успешного поиска возвращает
        /// пассажира. В случае неуспешного поиска возвращает null.
        /// </summary>
        /// <param name="ID">Номер паспорта.</param>
        /// <exception cref="KeyNotFoundException"></exception>
        public static Passenger Search(int ID)
        {
            foreach(Passenger Psg in AllPassengers)
            {
                if (Psg.ID == ID)
                {
                    return Psg;
                }
            }
            return null;
        }


        /// <summary>
        /// Возвращает список пассажиров, удовлетворяющих
        /// параметрам поискового запроса.
        /// </summary>
        /// <param name="LName">Фамилия пассажира.</param>
        /// <param name="FName">Имя пассажира.</param>
        /// <param name="TypeOfTicket">Тип билета пассажира.</param>
        /// <returns>Список объектов класса Passenger.</returns>
        public static List<Passenger> Search(string LName, string FName, string TypeOfTicket)
        {
            List <Passenger> Psgs   = AllPassengers;
            
            if (LName != "")
            {
                Psgs    = Passenger.SearchByLName(LName, Psgs);
            }

            if (FName != "")
            {
                Psgs    = Passenger.SearchByFName(FName, Psgs);
            }

            if (TypeOfTicket != "")
            {
                Psgs    = Passenger.SearchByTypeOfTicket(TypeOfTicket, Psgs);
            }

            return Psgs;
        }

        /// <summary>
        /// Возвращает список пассажиров с искомой фамилией.
        /// </summary>
        /// <param name="LName">Фамилия искомого пассажира.</param>
        /// <param name="Psgs">Список пассажиров, в котором проводится поиск.</param>
        /// <returns></returns>
        private static List<Passenger> SearchByLName(string LName, List<Passenger> Psgs)
        {
            List<Passenger> ResultPsgs  = new List<Passenger>();
            foreach(Passenger Psg in Psgs)
            {
                if (Psg.LastName == LName)
                    ResultPsgs.Add(Psg);
            }
            return ResultPsgs;
        }

        /// <summary>
        /// Возвращает список пассажиров с искомым именем.
        /// </summary>
        /// <param name="FName">Имя искомого пассажира.</param>
        /// <param name="Psgs">Список пассажиров, в котором проводится поиск.</param>
        /// <returns></returns>
        private static List<Passenger> SearchByFName(string FName, List<Passenger> Psgs)
        {
            List<Passenger> ResultPsgs  = new List<Passenger>();
            foreach(Passenger Psg in Psgs)
            {
                if (Psg.FirstName == FName)
                    ResultPsgs.Add(Psg);
            }
            return ResultPsgs;
        }


        /// <summary>
        /// Возвращает список пассажиров с искомым типом билета.
        /// </summary>
        /// <param name="TypeOfTicket">Тип билета искомого пассажира.</param>
        /// <param name="Psgs">Список пассажиров, в котором проводится поиск.</param>
        /// <returns></returns>
        private static List<Passenger> SearchByTypeOfTicket(string TypeOfTicket, List<Passenger> Psgs)
        {
            List<Passenger> ResultPsgs  = new List<Passenger>();
            foreach(Passenger Psg in Psgs)
            {
                if (Passenger.ContainTypeOfTicket(Psg, TypeOfTicket))
                {
                    ResultPsgs.Add(Psg);
                }
            }
            return ResultPsgs;
        }

        /// <summary>
        /// Возвращает истину, если у пассажира имеется хотя бы
        /// один билет искомого типа.
        /// </summary>
        /// <param name="Psg">Пассажир.</param>
        /// <param name="TypeOfTicket">Искомый тип билета.</param>
        /// <returns></returns>
        private static bool ContainTypeOfTicket(Passenger Psg, string TypeOfTicket)
        {
            List<Ticket> Tcks   = Psg.Tickets;
            foreach (Ticket Tck in Tcks)
            {
                if (Tck.Type == TypeOfTicket)
                {
                    return true;
                }
            }
            return false;
        }

#endregion


        #region Свойства

        /// <summary>
        /// Возвращает номер паспорта.
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { if ((value >= 1000) && (value <= 9999)) _id = value; }
        }

        /// <summary>
        /// Возвращает имя пассажира.
        /// </summary>
        public string FirstName
        {  
            get { return _firstName; }
            set { if (value.Length != 0) _firstName = value; }
        }

        /// <summary>
        /// Возвращает фамилию пассажира.
        /// </summary>
        public string LastName
        {  
            get { return _lastName; }
            set { if (value.Length != 0) _lastName = value; }
        }

        /// <summary>
        /// Возвращает список билетов, имеющихся у пассажира.
        /// </summary>
        public List<Ticket> Tickets { get {return _tickets;} }

        /// <summary>
        /// Возвращает список всех пассажиров.
        /// </summary>
        static List<Passenger> AllPassengers { get { return _allPassengers; } } 
    }

        #endregion

}

#region Тесты


    /*
    /// <summary>
    /// Класс с тестами для конструктора и свойств класса Passenger.
    /// </summary>
    [TestFixture]
    class TestPassenger
    {
        [Test]
        public static void TPassengerConstructor([Random(1000, 2000, 50)]                       int TNumber, 
                                                 [Values("Алёшина", "Румянцева", "Трофименко")] string TFirstName,
                                                 [Values("Анастасия", "Ксения", "Дарья")]       string TLastName,
                                                 [Values("Плацкарт", "Купе")]                   string TType)
        {
            Passenger TPassenger = new Passenger(TNumber, TFirstName, TLastName, TType);
        
            Assert.IsInstanceOf<Passenger>(TPassenger);
            Assert.AreEqual(TNumber, TPassenger.ID);
            Assert.AreEqual(TFirstName, TPassenger.FirstName);
            Assert.AreEqual(TLastName, TPassenger.LastName);
            Assert.AreEqual(TType, TPassenger.TypeOfTicket);
        }

        [Test]
        public static void TPassengerPropety([Random(-1000, 11000, 100)]                    int TNumber, 
                                             [Values("Алёшина", "Румянцева", "Трофименко")] string TFirstName,
                                             [Values("Анастасия", "Ксения", "Дарья")]       string TLastName,
                                             [Values("Плацкарт", "Купе")]                   string TType)
        {
            Passenger TPassenger = new Passenger(TNumber, TFirstName, TLastName, TType);
        
            if ((TNumber >= 1000) && (TNumber <=9999))
            { Assert.AreEqual(TNumber, TPassenger.ID); }
            else
            { Assert.AreEqual(0, TPassenger.ID); }
        }
    }
    */
#endregion
