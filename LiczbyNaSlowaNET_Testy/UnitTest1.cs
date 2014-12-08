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
            Assert.AreEqual("trzynascie", konwerter.ZamienNaSlowa(13));
            Assert.AreEqual("siedemnascie", konwerter.ZamienNaSlowa(17));
            Assert.AreEqual("osiemnascie", konwerter.ZamienNaSlowa(18));
            Assert.AreEqual("dwadziescia", konwerter.ZamienNaSlowa(20));
            Assert.AreEqual("osiemdziesiat cztery", konwerter.ZamienNaSlowa(84));
        }

        [TestMethod]
        public void TestSetek()
        {
            Assert.AreEqual("sto dwadziescia trzy", konwerter.ZamienNaSlowa(123));
            Assert.AreEqual("czterysta trzydziesci trzy", konwerter.ZamienNaSlowa(433));
            Assert.AreEqual("trzysta dwadziescia piec", konwerter.ZamienNaSlowa(325));
            Assert.AreEqual("siedemset piecdziesiat szesc", konwerter.ZamienNaSlowa(756));
            Assert.AreEqual("dziewiecset dziewiecdziesiat dziewiec", konwerter.ZamienNaSlowa(999));
        }

        [TestMethod]
        public void TestTysiecy()
        {
            Assert.AreEqual("jeden tysiac dwa".Trim(), konwerter.ZamienNaSlowa(1002));
            Assert.AreEqual("sto dwadziescia tysiecy trzydziesci".Trim(), konwerter.ZamienNaSlowa(120030));
            Assert.AreEqual("sto dwadziescia trzy tysiace".Trim(), konwerter.ZamienNaSlowa(123000));
            Assert.AreEqual("sto dwadziescia trzy tysiace trzydziesci dwa".Trim(), konwerter.ZamienNaSlowa(123032));
            Assert.AreEqual("osiemset dwadziescia cztery tysiace siedemset dwa".Trim(), konwerter.ZamienNaSlowa(824702));
            Assert.AreEqual("sto dwadziescia trzy tysiace trzysta szescdziesiat".Trim(), konwerter.ZamienNaSlowa(123360));
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
