
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class Unity
    {
        private Converter converter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.converter = new Converter();
        }

        [TestMethod]
        public void Test_0()
        {
            Assert.AreEqual("zero", converter.Convert(0));
        }

        [TestMethod]
        public void Test_3()
        {
            Assert.AreEqual("trzy", converter.Convert(3));
        }
    }
}
