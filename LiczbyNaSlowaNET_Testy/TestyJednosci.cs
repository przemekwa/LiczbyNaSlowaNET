
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class TestyJednosci
    {
        private Converter konwerter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.konwerter = new Converter();
        }

        [TestMethod]
        public void Test_0()
        {
            Assert.AreEqual("zero", konwerter.Convert(0));
        }

        [TestMethod]
        public void Test_3()
        {
            Assert.AreEqual("trzy", konwerter.Convert(3));
        }
    }
}
