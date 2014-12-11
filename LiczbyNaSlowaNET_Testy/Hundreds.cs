
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class Hundreds
    {
        [TestMethod]
        public void Test_123()
        {
            Assert.AreEqual("sto dwadziescia trzy", NumberToTextConverter.Convert(123));
        }

        [TestMethod]
        public void Test_403()
        {
            Assert.AreEqual("czterysta trzy", NumberToTextConverter.Convert(403));
        }

        [TestMethod]
        public void Test_320()
        {
            Assert.AreEqual("trzysta dwadziescia", NumberToTextConverter.Convert(320));
        }

        [TestMethod]
        public void Test_700()
        {
            Assert.AreEqual("siedemset", NumberToTextConverter.Convert(700));
        }

        [TestMethod]
        public void Test_999()
        {
            Assert.AreEqual("dziewiecset dziewiecdziesiat dziewiec", NumberToTextConverter.Convert(999));
        }
    }
}
