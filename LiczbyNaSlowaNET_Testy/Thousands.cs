
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class Thousands 
    {
        [TestMethod]
        public void Test_1002()
        {
            Assert.AreEqual("jeden tysiac dwa", Converter.Convert(1002));
        }

        [TestMethod]
        public void Test_120030()
        {
            Assert.AreEqual("sto dwadziescia tysiecy trzydziesci", Converter.Convert(120030));
        }

        [TestMethod]
        public void Test_123000()
        {
            Assert.AreEqual("sto dwadziescia trzy tysiace", Converter.Convert(123000));
        }

        [TestMethod]
        public void Test_123032()
        {
            Assert.AreEqual("sto dwadziescia trzy tysiace trzydziesci dwa", Converter.Convert(123032));
        }

        [TestMethod]
        public void Test_123360()
        {
            Assert.AreEqual("sto dwadziescia trzy tysiace trzysta szescdziesiat", Converter.Convert(123360));
        }

        [TestMethod]
        public void Test_824702()
        {
            Assert.AreEqual("osiemset dwadziescia cztery tysiace siedemset dwa", Converter.Convert(824702));
        }

        [TestMethod]
        public void Test_14100()
        {
            Assert.AreEqual("czternascie tysiecy sto", Converter.Convert(14100));
        }
    }
}
