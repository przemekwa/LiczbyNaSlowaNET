
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class TestyMilionow
    {
        private Konwerter konwerter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.konwerter = new Konwerter();
        }

        [TestMethod]
        public void Test_1000000()
        {
            Assert.AreEqual("jeden milion", konwerter.ZamienNaSlowa(1000000));
        }

        [TestMethod]
        public void Test_123000000()
        {
            Assert.AreEqual("sto dwadziescia trzy miliony", konwerter.ZamienNaSlowa(123000000));
        }

        [TestMethod]
        public void Test_123000021()
        {
            Assert.AreEqual("sto dwadziescia trzy miliony dwadziescia jeden", konwerter.ZamienNaSlowa(123000021));
        }

        [TestMethod]
        public void Test_3200000()
        {
            Assert.AreEqual("trzy miliony dwiescie tysiecy", konwerter.ZamienNaSlowa(3200000));
        }

        [TestMethod]
        public void Test_13200000()
        {
            Assert.AreEqual("trzynascie milionow dwiescie tysiecy", konwerter.ZamienNaSlowa(13200000));
        }
    }
}
