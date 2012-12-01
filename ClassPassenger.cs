using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Xml;

namespace Trains
{
    struct Ticket
    {
        /// <summary>
        /// Номер поезда, указанный в билете.
        /// </summary>
        public int      Number;
     
        /// <summary>
        /// Тип билета.
        /// </summary>
        public string   Type;


        /// <summary>
        /// Инициализирует билет по номеру поезда и типу билета.
        /// </summary>
        /// <param name="Number">Номер поезда.</param>
        /// <param name="Type">Тип билета.</param>
        public Ticket(int NumberOfTrain, string TypeOfTicket)
        {
            Number = NumberOfTrain;
            Type   = TypeOfTicket;
        }
    }

    class Passenger
    {
        #region Поля и методы

        int             _id;
        string          _firstName;
        string          _lastName;
        List<Ticket>    _tickets;

        /// <summary>
        /// Статический словарь, содержащий информацию обо всех пассажирах. Ключ - номер паспорта пассажира. Значение - ссылка на объект класса Passenger.
        /// </summary>
        static Dictionary<int, Passenger> AllPassengers = new Dictionary<int, Passenger>();

        /// <summary>
        /// Инициализирует пассажира по номеру паспорта, имени, фамилии и билету.
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
        /// Добавляет пассажира в статический словарь AllPassengers.
        /// </summary>
        private void AddToAllPassengers()
        {
            AllPassengers.Add(this.ID, this);
        }

        public static bool Contain(int ID)
        {
            return (AllPassengers.ContainsKey(ID));
        }


        /// <summary>
        /// Удаляет пассажира по номеру паспорта.
        /// </summary>
        /// <param name="ID">Номер паспорта.</param>
        public void Remove(int ID)
        {
            AllPassengers.Remove(this.ID);
        }

        public static void AddTicket(int ID, Ticket TheTicket)
        {
            AllPassengers[ID]._tickets.Add(TheTicket);
        }

        /// <summary>
        /// Возвращает пассажира из словаря по номеру паспорта.
        /// </summary>
        /// <param name="ID">Номер паспорта.</param>
        /// <exception cref="KeyNotFoundException"></exception>
        public static Passenger Search(int ID)
        {
            return AllPassengers[ID];
        }



        public static List<Passenger> Search(string LName, string FName, string TypeOfTicket)
        {
            List <Passenger> Psgs   = Passenger.ConvertToListOfPas();
            
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


        /// <summary>
        /// Возвращает список всех пассажиров.
        /// </summary>
        /// <returns></returns>
        private static List<Passenger> ConvertToListOfPas()
        {
            List<Passenger> Psgs    = new List<Passenger>();        
            foreach (KeyValuePair<int, Passenger> kvp in AllPassengers)
            {
                Psgs.Add(kvp.Value);
            }
            return Psgs;
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
}