
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{
    [TestClass]
    public class Tens
    {
        public NumberToTextOptions NumberToTextOptions { get; set; } = new NumberToTextOptions { Dictionary = new PolishWithsStemsDictionary() };

        [TestMethod]
        public void Test_11()
        {
            Assert.AreEqual("jedenaście", NumberToText.Convert(11, this.NumberToTextOptions));
        }

        [TestMethod]
        public void Test_13()
        {
            Assert.AreEqual("trzynaście", NumberToText.Convert(13, this.NumberToTextOptions));
        }

        [TestMethod]
        public void Test_18()
        {
            Assert.AreEqual("osiemnaście", NumberToText.Convert(18, this.NumberToTextOptions));
        }

        [TestMethod]
        public void Test_20()
        {
            Assert.AreEqual("dwadzieścia", NumberToText.Convert(20, this.NumberToTextOptions));
        }

        [TestMethod]
        public void Test_84()
        {
            Assert.AreEqual("osiemdziesiąt cztery", NumberToText.Convert(84, this.NumberToTextOptions));
        }
    }
}
