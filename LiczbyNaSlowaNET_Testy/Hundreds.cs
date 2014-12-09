
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class Hundreds
    {
        private Converter converter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.converter = new Converter();
        }

        [TestMethod]
        public void Test_123()
        {
            Assert.AreEqual("sto dwadziescia trzy", converter.Convert(123));
        }

        [TestMethod]
        public void Test_403()
        {
            Assert.AreEqual("czterysta trzy", converter.Convert(403));
        }

        [TestMethod]
        public void Test_320()
        {
            Assert.AreEqual("trzysta dwadziescia", converter.Convert(320));
        }

        [TestMethod]
        public void Test_700()
        {
            Assert.AreEqual("siedemset", converter.Convert(700));
        }

        [TestMethod]
        public void Test_999()
        {
            Assert.AreEqual("dziewiecset dziewiecdziesiat dziewiec", converter.Convert(999));
        }
    }
}
