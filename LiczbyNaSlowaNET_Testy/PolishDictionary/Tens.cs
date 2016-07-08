﻿
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
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
            Assert.AreEqual("trzynascie", NumberToText.Convert(13));
        }

        [TestMethod]
        public void Test_18()
        {
            Assert.AreEqual("osiemnascie", NumberToText.Convert(18));
        }

        [TestMethod]
        public void Test_20()
        {
            Assert.AreEqual("dwadziescia", NumberToText.Convert(20));
        }

        [TestMethod]
        public void Test_84()
        {
            Assert.AreEqual("osiemdziesiat cztery", NumberToText.Convert(84));
        }
    }
}
