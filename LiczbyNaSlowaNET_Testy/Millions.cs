
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class Millions
    {
        private Converter converter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.converter = new Converter();
        }

        [TestMethod]
        public void Test_1000000()
        {
            Assert.AreEqual("jeden milion", converter.Convert(1000000));
        }

        [TestMethod]
        public void Test_123000000()
        {
            Assert.AreEqual("sto dwadziescia trzy miliony", converter.Convert(123000000));
        }

        [TestMethod]
        public void Test_123000021()
        {
            Assert.AreEqual("sto dwadziescia trzy miliony dwadziescia jeden", converter.Convert(123000021));
        }

        [TestMethod]
        public void Test_3200000()
        {
            Assert.AreEqual("trzy miliony dwiescie tysiecy", converter.Convert(3200000));
        }

        [TestMethod]
        public void Test_13200000()
        {
            Assert.AreEqual("trzynascie milionow dwiescie tysiecy", converter.Convert(13200000));
        }
    }
}
