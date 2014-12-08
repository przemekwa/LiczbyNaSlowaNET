using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestKonwersji()
        {
            var konwerter = new Konwerter();

            Assert.AreEqual(konwerter.ZamienNaSlowa(1000), "tysiąc");

            Assert.AreEqual(konwerter.ZamienNaSlowa(100), "sto");

            Assert.AreEqual(konwerter.ZamienNaSlowa(550), "pięć set piędzisiąt");
           

        }
    }
}
