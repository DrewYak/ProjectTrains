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
        public Ticket(int N, string T)
        {
            Number = N;
            Type   = T;
        }
    }

    class Passenger
    {
        int    _id;
        string _firstName;
        string _lastName;

        /// <summary>
        /// Статический словарь, содержащий информацию обо всех пассажирах. Ключ - номер паспорта пассажира. Значение - ссылка на объект класса Passenger.
        /// </summary>
        static Dictionary<int, Passenger> AllPassengers = new Dictionary<int, Passenger>();

        
        /// <summary>
        /// Инициализирует пассажира по номеру паспорта, имени, фамилии и типу билета.
        /// </summary>
        /// <param name="ID">Номер паспорта.</param>
        /// <param name="FirstName">Имя.</param>
        /// <param name="LastName">Фамилия.</param>
        public Passenger(int ID, string FirstName, string LastName)
        {
            this.ID             = ID;
            this.FirstName      = FirstName;
            this.LastName       = LastName;
        }

        /// <summary>
        /// Инициализирует пассажира по номеру паспорта, имени, фамилии и билету.
        /// </summary>
        /// <param name="ID">Номер паспорта.</param>
        /// <param name="FirstName">Имя.</param>
        /// <param name="LastName">Фамилия.</param>
        /// <param name="TheTicket">Билет.</param>
        public Passenger(int ID, string FirstName, string LastName, Ticket TheTicket)
        {
            this.ID             = ID;
            this.FirstName      = FirstName;
            this.LastName       = LastName;
            this.Tickets        = new List<Ticket>();
            this.Tickets.Add(TheTicket);
        }


        /// <summary>
        /// Добавляет пассажира в статический словарь AllPassengers.
        /// </summary>
        public void Add()
        {
            AllPassengers.Add(this.ID, this);
        }

        /// <summary>
        /// Удаляет пассажира по номеру паспорта.
        /// </summary>
        /// <param name="ID">Номер паспорта.</param>
        public void Remove(int ID)
        {
            AllPassengers.Remove(this.ID);
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
        
        /// <summary>
        /// Добавляет данные о пассажире из узла XML-документа (предполагается, что из узла Passenger) в статический словарь AllPassengers. 
        /// </summary>
        /// <param name="Psg">Узел Passenger.</param>
        /// <param name="NumberOfTrain">Номер поезда.</param>
        private static void AddToDictFromNodePas(XmlNode Psg, int NumberOfTrain)
        {
            int         ID              = Convert.ToInt32(Psg.SelectSingleNode("ID").InnerText);
            string      LastName        = Psg.SelectSingleNode("LName").InnerText;
            string      FirstName       = Psg.SelectSingleNode("FName").InnerText;
            string      Type            = Psg.SelectSingleNode("TypeOfTicket").InnerText;
            Ticket      TheTicket       = new Ticket(NumberOfTrain, Type);        
            Passenger   ThePassenger    = new Passenger(ID, FirstName, LastName, TheTicket);
            ThePassenger.Add();
        }

        /// <summary>
        /// Извлекает номер поезда из узла XML-документа (предполагается, что из узла Train) и возвращает его.
        /// </summary>
        /// <param name="Trn">Узел XML-документа.</param>
        /// <returns></returns>
        private static int GetNumberOfTrainFromNodeTrain(XmlNode Trn)
        {
            return Convert.ToInt32(Trn.SelectSingleNode("Number").InnerText);
        }

        /// <summary>
        /// Возвращает список узлов типа Passenger из узла типа Train.
        /// </summary>
        /// <param name="Trn">Узел XML-документа (Узел типа Train).</param>
        private static XmlNodeList GetXmlNodeListOfPassengerFromNodeTrain(XmlNode Trn)
        {
            // Создаём временный узел TempNode. Все его дочерние узлы - это узлы типа Passenger 
            XmlNode TempNode = Trn.SelectSingleNode("Passengers");

            // Выбираем из временного узла TempNode все узлы типа Passenger и делаем из них
            // XmlNodeList, после чего возвращаем этот список XML-узлов.
            return  TempNode.SelectNodes("Passenger");
        }

        /// <summary>
        /// Добавляет данные к статическим словарям AllTrains и AllPassengers из списка узлов типа Train.
        /// </summary>
        /// <param name="Trains">Список узлов типа Train.</param>
        private static void AddDataFromXmlNodeListTrains(XmlNodeList Trains)
        {
            for (int j = 0, m = Trains.Count; j < m; j++)
            {
                int         NumberOfTrain   = GetNumberOfTrainFromNodeTrain(Trains[j]);            
                XmlNodeList Pass            = GetXmlNodeListOfPassengerFromNodeTrain(Trains[j]);
          
                for (int i = 0, n = Pass.Count; i < n; i++)
                {
                    AddToDictFromNodePas(Pass[i], NumberOfTrain);
                }
            }
        }

        /// <summary>
        /// Загружает данные из XML-документа.
        /// </summary>
        /// <param name="FileName">Имя XML-документа.</param>
        public static void AddDataFromFile(string FileName)
        {
            XmlDocument doc     = new XmlDocument();
            doc.Load(FileName);
            XmlNodeList Trains  = doc.GetElementsByTagName("Train");
            AddDataFromXmlNodeListTrains(Trains);
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

        /// <summary>
        /// Возвращает список билетов, имеющихся у пассажира.
        /// </summary>
        public List<Ticket> Tickets { get; set; }

    }
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
}