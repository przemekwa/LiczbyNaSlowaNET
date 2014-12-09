
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class TestyMilionow
    {
        private Converter konwerter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.konwerter = new Converter();
        }

        [TestMethod]
        public void Test_1000000()
        {
            Assert.AreEqual("jeden milion", konwerter.Convert(1000000));
        }

        [TestMethod]
        public void Test_123000000()
        {
            Assert.AreEqual("sto dwadziescia trzy miliony", konwerter.Convert(123000000));
        }

        [TestMethod]
        public void Test_123000021()
        {
            Assert.AreEqual("sto dwadziescia trzy miliony dwadziescia jeden", konwerter.Convert(123000021));
        }

        [TestMethod]
        public void Test_3200000()
        {
            Assert.AreEqual("trzy miliony dwiescie tysiecy", konwerter.Convert(3200000));
        }

        [TestMethod]
        public void Test_13200000()
        {
            Assert.AreEqual("trzynascie milionow dwiescie tysiecy", konwerter.Convert(13200000));
        }
    }
}
