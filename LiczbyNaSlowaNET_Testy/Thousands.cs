
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class Thousands 
    {
        private Converter converter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.converter = new Converter();
        }

        [TestMethod]
        public void Test_1002()
        {
            Assert.AreEqual("jeden tysiac dwa", converter.Convert(1002));
        }

        [TestMethod]
        public void Test_120030()
        {
            Assert.AreEqual("sto dwadziescia tysiecy trzydziesci", converter.Convert(120030));
        }

        [TestMethod]
        public void Test_123000()
        {
            Assert.AreEqual("sto dwadziescia trzy tysiace", converter.Convert(123000));
        }

        [TestMethod]
        public void Test_123032()
        {
            Assert.AreEqual("sto dwadziescia trzy tysiace trzydziesci dwa", converter.Convert(123032));
        }

        [TestMethod]
        public void Test_123360()
        {
            Assert.AreEqual("sto dwadziescia trzy tysiace trzysta szescdziesiat", converter.Convert(123360));
        }

        [TestMethod]
        public void Test_824702()
        {
            Assert.AreEqual("osiemset dwadziescia cztery tysiace siedemset dwa", converter.Convert(824702));
        }
    }
}
