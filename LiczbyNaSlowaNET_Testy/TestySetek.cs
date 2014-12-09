
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class TestySetek
    {
        private Converter konwerter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.konwerter = new Converter();
        }

        [TestMethod]
        public void Test_123()
        {
            Assert.AreEqual("sto dwadziescia trzy", konwerter.Convert(123));
        }

        [TestMethod]
        public void Test_403()
        {
            Assert.AreEqual("czterysta trzy", konwerter.Convert(403));
        }

        [TestMethod]
        public void Test_320()
        {
            Assert.AreEqual("trzysta dwadziescia", konwerter.Convert(320));
        }

        [TestMethod]
        public void Test_700()
        {
            Assert.AreEqual("siedemset", konwerter.Convert(700));
        }

        [TestMethod]
        public void Test_999()
        {
            Assert.AreEqual("dziewiecset dziewiecdziesiat dziewiec", konwerter.Convert(999));
        }
    }
}
