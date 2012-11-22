using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Xml;


namespace Trains
{
    class Ticket
    {
        /// <summary>
        /// Инициализирует билет по номеру поезда и типа билета
        /// </summary>
        /// <param name="Number"> </param>
        /// <param name="Type"></param>
        public Ticket(int Number, string Type)
        {
            this.Number = Number;
            this.Type   = Type;
        }

        public int      Number  { get; set; }
        public string   Type    { get; set; }
    }

    class Passenger
    {
        int    _id;
        string _firstName;
        string _lastName;
        List Ticket;
    
        static Dictionary<int, Passenger> AllPassengers = new Dictionary<int, Passenger>();

        List<Ticket> Tickets = new List<Ticket>;

        /// <summary>
        /// Инициализирует пассажира по номеру паспорта, имени, фамилии и типу билета.
        /// </summary>
        /// <param name="ID">Номер паспорта.</param>
        /// <param name="FirstName">Имя.</param>
        /// <param name="LastName">Фамилия.</param>
        /// <param name="TypeOfTicket">Тип билета.</param>
        public Passenger(int ID, string FirstName, string LastName)
        {
            this.ID             = ID;
            this.FirstName      = FirstName;
            this.LastName       = LastName;
        }

        /// <summary>
        /// Инициализирует пассажира Иван Иванов
        /// </summary>
        public Passenger()
        {
            this.ID             = 9999;
            this.FirstName      = "Иван" ;
            this.LastName       = "Иванов";
        }

        /// <summary>
        /// Добавляет пассажиров в статический словарь AllPassengers.
        /// </summary>
        public void Add()
        {
            AllPassengers.Add(this.ID, this);
        }

        /// <summary>
        /// Удаляет пассажира по номеру паспорта.
        /// </summary>
        /// <param name="ID">Номер паспорта</param>
        public void Remove(int ID)
        {
            AllPassengers.Remove(this.ID);
        }

        /// <summary>
        /// Возвращает пассажира из словаря по номеру паспорта.
        /// </summary>
        /// <param name="ID">Номер паспорта</param>
        /// <returns></returns>
        public static Passenger Search(int ID)
        {
            return AllPassengers[ID];
        }

        /// <summary>
        /// Загружает данные из xml файла
        /// </summary>
        /// <param name="FileName"></param>
   

        public static void AddDataFromFile(string FileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FileName);

            XmlNodeList Pass = doc.GetElementsByTagName("Passenger");

            for (int i = 0, n=Pass.Count; i < n; i++)
            {
                Passenger ThePassenger = new Passenger();

                ThePassenger.ID             = Convert.ToInt32(Pass[i].FirstChild.InnerText);
                ThePassenger.LastName       = Pass[i].FirstChild.NextSibling.InnerText;
                ThePassenger.FirstName      = Pass[i].FirstChild.NextSibling.NextSibling.InnerText;
                

                ThePassenger.Add();
            }
        }


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

        
    }

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

}