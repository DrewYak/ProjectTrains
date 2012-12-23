using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NUnit.Framework;

namespace Trains
{
    [TestFixture]
    class TestPsg
    {
        [Test]
        public void TestSearch()
        {
            //try
            //{
                string FileName = @"E:\Trains\Project\Trains_2\ProjectTrains\TrainsAndAnotherStuff.xml";
                Data.LoadFromFile(FileName);

                Passenger Psg0 = Passenger.Search(1000);
                Assert.AreEqual("Румянцева", Psg0.LastName);
                Assert.AreEqual("Ксения", Psg0.FirstName);
                Assert.AreEqual("Плацкарт", Psg0.Tickets[0].Type);
                Assert.AreEqual(10, Psg0.Tickets[0].Train.Number);

                Passenger ActPsg2 = Passenger.Search(2000);
                Assert.AreEqual(null, ActPsg2);
                                


                List<Passenger> FName1 = Passenger.Search("Трофименко", "", "");
                Assert.AreEqual("Дарья", FName1[0].FirstName);
                Assert.AreEqual("Плацкарт", FName1[0].Tickets[0].Type);
                Assert.AreEqual(10, FName1[0].Tickets[0].Train.Number);

                List<Passenger> FName4 = Passenger.Search("Иванов", "", "");
                Assert.IsEmpty(FName4);



                List<Passenger> LName2 = Passenger.Search("", "Анастасия", "");
                Assert.AreEqual("Алёшина", LName2[0].LastName);
                Assert.AreEqual("Плацкарт", LName2[0].Tickets[0].Type);
                Assert.AreEqual(10, LName2[0].Tickets[0].Train.Number);

                List<Passenger> LName4 = Passenger.Search("", "Иван", "");
                Assert.IsEmpty(LName4);




                List<Passenger> LPas = Passenger.Search("", "", "Плацкарт");
                Assert.AreEqual(4, LPas.Count);
                Assert.AreEqual(1000, LPas[0].ID);
                Assert.AreEqual(1001, LPas[1].ID);
                Assert.AreEqual(1002, LPas[2].ID);
                Assert.AreEqual(1003, LPas[3].ID);

                List<Passenger> LPas1 = Passenger.Search("", "", "Купе");
                Assert.IsEmpty(LPas1);

            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка!");
            //}
        }
    }

[TestFixture]
    class TestTrn
    {
    [Test]
    public void TestSearch1()
    {
       //try
       //{
            string FileName = @"E:\Trains\Project\Trains_2\ProjectTrains\TrainsAndAnotherStuff.xml";
            Data.LoadFromFile(FileName);

            
            Train Trn0 = Train.Search(10);
            Assert.AreEqual(4, Trn0.CountOfPas);
            Assert.AreEqual("Москва", Trn0.PointOfDeparture);
            Assert.AreEqual("Санкт-Петербург", Trn0.PointOfArrival);


            Train Trn1 = Train.Search(99);
            Assert.AreEqual(null, Trn1);



            List<Train> Stn1 = Train.Search("Москва","");
            Assert.AreEqual("06:00", Stn1[0].TimeOfDeparture);
            Assert.AreEqual(1000, Stn1[0].Tickets[0].Passenger.ID);

            List<Train> Stn2 = Train.Search("", "Санкт-Петербург");
            Assert.AreEqual("16:00", Stn2[0].TimeOfArrival);
            Assert.AreEqual("Плацкарт", Stn1[0].Tickets[0].Type);

            List<Train> Stn3 = Train.Search("Кострома", "");
            Assert.IsEmpty(Stn3);


        //}
        //catch
        //{
        //    MessageBox.Show("Ошибка!");
        //}
    }
  }
}