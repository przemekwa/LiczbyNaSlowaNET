
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class TestySetek
    {
        private Konwerter konwerter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.konwerter = new Konwerter();
        }

        [TestMethod]
        public void Test_123()
        {
            Assert.AreEqual("sto dwadziescia trzy", konwerter.ZamienNaSlowa(123));
        }

        [TestMethod]
        public void Test_403()
        {
            Assert.AreEqual("czterysta trzy", konwerter.ZamienNaSlowa(403));
        }

        [TestMethod]
        public void Test_320()
        {
            Assert.AreEqual("trzysta dwadziescia", konwerter.ZamienNaSlowa(320));
        }

        [TestMethod]
        public void Test_700()
        {
            Assert.AreEqual("siedemset", konwerter.ZamienNaSlowa(700));
        }

        [TestMethod]
        public void Test_999()
        {
            Assert.AreEqual("dziewiecset dziewiecdziesiat dziewiec", konwerter.ZamienNaSlowa(999));
        }
    }
}
