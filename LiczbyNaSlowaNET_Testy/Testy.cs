
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
   
    public class Testy
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
            Assert.AreEqual("czterysta trzy", konwerter.ZamienNaSlowa(403));
            Assert.AreEqual("trzysta dwadziescia", konwerter.ZamienNaSlowa(320));
            Assert.AreEqual("siedemset", konwerter.ZamienNaSlowa(700));
            Assert.AreEqual("dziewiecset dziewiecdziesiat dziewiec", konwerter.ZamienNaSlowa(999));
        }

        [TestMethod]
        public void TestTysiecy()
        {
            Assert.AreEqual("jeden tysiac dwa", konwerter.ZamienNaSlowa(1002));
            Assert.AreEqual("sto dwadziescia tysiecy trzydziesci", konwerter.ZamienNaSlowa(120030));
            Assert.AreEqual("sto dwadziescia trzy tysiace", konwerter.ZamienNaSlowa(123000));
            Assert.AreEqual("sto dwadziescia trzy tysiace trzydziesci dwa", konwerter.ZamienNaSlowa(123032));
            Assert.AreEqual("osiemset dwadziescia cztery tysiace siedemset dwa", konwerter.ZamienNaSlowa(824702));
            Assert.AreEqual("sto dwadziescia trzy tysiace trzysta szescdziesiat", konwerter.ZamienNaSlowa(123360));
        }

        [TestMethod]
        public void TestMilionow()
        {
            Assert.AreEqual("jeden milion", konwerter.ZamienNaSlowa(1000000));
            Assert.AreEqual("sto dwadziescia trzy miliony", konwerter.ZamienNaSlowa(123000000));
            Assert.AreEqual("sto dwadziescia trzy miliony dwadziescia jeden", konwerter.ZamienNaSlowa(123000021));
            Assert.AreEqual("trzy miliony dwiescie tysiecy", konwerter.ZamienNaSlowa(3200000));
            Assert.AreEqual("trzynascie milionow dwiescie tysiecy", konwerter.ZamienNaSlowa(13200000));
        }

        [TestMethod]
        public void TestMiliardow()
        {
            Assert.AreEqual("dwa miliardy", konwerter.ZamienNaSlowa(2000000000));
        }


    }
}
