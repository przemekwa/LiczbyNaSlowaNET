
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{
    [TestClass]
    public class Hundreds : TestBase
    {
        [TestMethod]
        public void Test_123()
        {
            Assert.AreEqual("sto dwadzieścia trzy", NumberToText.Convert(123, this.NumberToTextOptions));
        }

        [TestMethod]
        public void Test_403()
        {
            Assert.AreEqual("czterysta trzy", NumberToText.Convert(403));
        }

        [TestMethod]
        public void Test_320()
        {
            Assert.AreEqual("trzysta dwadziescia", NumberToText.Convert(320));
        }

        [TestMethod]
        public void Test_700()
        {
            Assert.AreEqual("siedemset", NumberToText.Convert(700));
        }

        [TestMethod]
        public void Test_999()
        {
            Assert.AreEqual("dziewiecset dziewiecdziesiat dziewiec", NumberToText.Convert(999));
        }
    }
}
