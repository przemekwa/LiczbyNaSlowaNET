
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class TestyJednosci
    {
        private Konwerter konwerter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.konwerter = new Konwerter();
        }

        [TestMethod]
        public void Test_0()
        {
            Assert.AreEqual("zero", konwerter.ZamienNaSlowa(0));
        }

        [TestMethod]
        public void Test_3()
        {
            Assert.AreEqual("trzy", konwerter.ZamienNaSlowa(3));
        }
    }
}
