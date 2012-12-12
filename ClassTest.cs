using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Trains
{
    [TestFixture]
    class TestPsg
    {
        [Test]
        public void TestSearch()
        {
            string FileName = @"E:\Trains\Project\Trains\TrainsAndAnotherStuff.xml";
            Data.LoadFromFile(FileName);
            
            Passenger Psg0 = Passenger.Search(1000);
            Assert.AreEqual("Румянцева", Psg0.LastName);
            Assert.AreEqual("Ксения",    Psg0.FirstName);
            Assert.AreEqual("Плацкарт",  Psg0.Tickets[0].Type);
            Assert.AreEqual(10, Psg0.Tickets[0].Train.Number);

            Passenger Psg1 = Passenger.Search(1001);
            Assert.AreEqual("Трофименко", Psg1.LastName);
            Assert.AreEqual("Дарья",      Psg1.FirstName);
            Assert.AreEqual("Плацкарт",   Psg1.Tickets[0].Type);
            Assert.AreEqual(10, Psg1.Tickets[0].Train.Number);

            Passenger Psg2 = Passenger.Search(1002);
            Assert.AreEqual("Алёшина",   Psg2.LastName);
            Assert.AreEqual("Анастасия", Psg2.FirstName);
            Assert.AreEqual("Плацкарт",  Psg2.Tickets[0].Type);
            Assert.AreEqual(10, Psg2.Tickets[0].Train.Number);

            Passenger Psg3 = Passenger.Search(1003);
            Assert.AreEqual("Яковличев", Psg3.LastName);
            Assert.AreEqual("Андрей",    Psg3.FirstName);
            Assert.AreEqual("Плацкарт",  Psg3.Tickets[0].Type);
            Assert.AreEqual(10, Psg3.Tickets[0].Train.Number);

            Passenger ActPsg2 = Passenger.Search(2000);
            Assert.AreEqual(null, ActPsg2);



            
                List<Passenger> FName0 = Passenger.Search("Румянцева", "", "");
                Assert.AreEqual("Ксения", FName0[0].FirstName);
                Assert.AreEqual("Плацкарт", FName0[0].Tickets[0].Type);
                Assert.AreEqual(10, FName0[0].Tickets[0].Train.Number);

                List<Passenger> FName1 = Passenger.Search("Трофименко", "", "");
                Assert.AreEqual("Дарья", FName1[0].FirstName);
                Assert.AreEqual("Плацкарт", FName1[0].Tickets[0].Type);
                Assert.AreEqual(10, FName1[0].Tickets[0].Train.Number);
            


            List<Passenger> LPas = Passenger.Search("", "", "Плацкарт");
            Assert.AreEqual(4,    LPas.Count);
            Assert.AreEqual(1000, LPas[0].ID);
            Assert.AreEqual(1001, LPas[1].ID);
            Assert.AreEqual(1002, LPas[2].ID);
            Assert.AreEqual(1003, LPas[3].ID);

            List<Passenger> LPas1 = Passenger.Search("", "", "Купе");
            Assert.IsEmpty(LPas1);
        }
    }
}