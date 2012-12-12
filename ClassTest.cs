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
            // Задаём имя файла.
            string FileName = "E:\\Trains\\Project\\Trains\\MainData.xml";
            // Загружаем данные в программу из файла.
            Data.LoadFromFile(FileName);
            // Ищем пассажира, используя метод Search.
            Passenger ActPsg    = Passenger.Search(1000);
            
            Assert.AreEqual("Румянцева",    ActPsg.LastName);
            Assert.AreEqual("Ксения",       ActPsg.FirstName);
            Assert.AreEqual(1000,           ActPsg.ID);

            Passenger ActPsg2   = Passenger.Search(2000);
            Assert.AreEqual(null, ActPsg2); 
            
            List<Passenger> ActPsg3   = Passenger.Search("Пупкин", "", "");
            Assert.IsEmpty(ActPsg3);
        }
    }
}