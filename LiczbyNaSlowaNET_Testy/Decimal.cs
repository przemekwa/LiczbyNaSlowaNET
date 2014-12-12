
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class Decimal
    {
        [TestMethod]
        public void Test_12_23()
        {
            Assert.AreEqual("dwanascie dwadziescia trzy", NumberToTextConverter.Convert(12.23M));
        }

        [TestMethod]
        public void Test_12()
        {
            Assert.AreEqual("dwanascie", NumberToTextConverter.Convert(12M));
        }

        [TestMethod]
        public void Test_0_12()
        {
            Assert.AreEqual("zero dwanascie", NumberToTextConverter.Convert(0.12M));
        }

        [TestMethod]
        public void Test_Infinity()
        {
            Assert.AreEqual("", NumberToTextConverter.Convert(999999999999999999999M));
        }

        [TestMethod]
        public void Test_13_0()
        {
            Assert.AreEqual("trzynascie zero", NumberToTextConverter.Convert(13.0M));
        }

        [TestMethod]
        public void Test_141000_23()
        {
            Assert.AreEqual("czternascie tysiecy sto dwadziescia trzy", NumberToTextConverter.Convert(14100.23M));
        }

        [TestMethod]
        public void Test_141000_230()
        {
            Assert.AreEqual("czternascie tysiecy sto dwadziescia trzy", NumberToTextConverter.Convert(14100.23M));
        }

        [TestMethod]
        public void Test_141000_23030()
        {
            Assert.AreEqual("czternascie tysiecy sto dwadziescia trzy", NumberToTextConverter.Convert(14100.23M));
        }

       
    }
}
