
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{
    [TestClass]
    public class Millions
    {
        [TestMethod]
        public void Test_1000000()
        {
            Assert.AreEqual("jeden milion", NumberToText.Convert(1000000));
        }

        [TestMethod]
        public void Test_123000000()
        {
            Assert.AreEqual("sto dwadziescia trzy miliony", NumberToText.Convert(123000000));
        }

        [TestMethod]
        public void Test_123000021()
        {
            Assert.AreEqual("sto dwadziescia trzy miliony dwadziescia jeden", NumberToText.Convert(123000021));
        }

        [TestMethod]
        public void Test_3200000()
        {
            Assert.AreEqual("trzy miliony dwiescie tysiecy", NumberToText.Convert(3200000));
        }

        [TestMethod]
        public void Test_13200000()
        {
            Assert.AreEqual("trzynascie milionow dwiescie tysiecy", NumberToText.Convert(13200000));
        }
    }
}
