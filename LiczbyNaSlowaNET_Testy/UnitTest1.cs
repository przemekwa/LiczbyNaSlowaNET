using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
   
    public class UnitTest1
    {

        private Konwerter konwerter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.konwerter = new Konwerter();
        }

     
        [TestMethod]
        public void TestZero()
        {
            Assert.AreEqual("zero", konwerter.ZamienNaSlowa(0));
        }

        [TestMethod]
        public void TestJednosci()
        {
            Assert.AreEqual("trzy", konwerter.ZamienNaSlowa(3));
        }

        [TestMethod]
        public void TestDziesiatek()
        {
            Assert.AreEqual("jedenascie", konwerter.ZamienNaSlowa(11));
        }

        [TestMethod]
        public void TestSetek()
        {
            Assert.AreEqual("sto dwadziescia trzy", konwerter.ZamienNaSlowa(123));
        }

        [TestMethod]
        public void TestTysiecy()
        {
            Assert.AreEqual("sto dwadziescia trzy tysiace".Trim(), konwerter.ZamienNaSlowa(123000));
        }

        [TestMethod]
        public void TestMilionow()
        {
            Assert.AreEqual("sto dwadziescia trzy miliony".Trim(), konwerter.ZamienNaSlowa(123000000));
        }

        [TestMethod]
        public void TestMiliardow()
        {
            Assert.AreEqual("dwa miliardy".Trim(), konwerter.ZamienNaSlowa(2000000000));
        }


    }
}
