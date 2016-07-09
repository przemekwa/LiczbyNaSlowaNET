
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{
    [TestClass]
    public class Decimal : TestBase
    {
        [TestMethod]
        public void Test_4_4()
        {
            Assert.AreEqual("cztery czterdziesci", NumberToText.Convert(4.4M, this.NumberToTextOptions));
        }

        [TestMethod]
        public void Test_4_40()
        {
            Assert.AreEqual("cztery czterdziesci", NumberToText.Convert(4.40M, this.NumberToTextOptions));
        }


        [TestMethod]
        public void Test_12_23()
        {
            Assert.AreEqual("dwanascie dwadziescia trzy", NumberToText.Convert(12.23M, this.NumberToTextOptions));
        }

        [TestMethod]
        public void Test_12()
        {
            Assert.AreEqual("dwanascie", NumberToText.Convert(12M, this.NumberToTextOptions));
        }

        [TestMethod]
        public void Test_0_12()
        {
            Assert.AreEqual("zero dwanascie", NumberToText.Convert(0.12M, this.NumberToTextOptions));
        }

        [TestMethod]
        public void Test_Infinity()
        {
            Assert.AreEqual("", NumberToText.Convert(999999999999999999999M));
        }

        [TestMethod]
        public void Test_13_0()
        {
            Assert.AreEqual("trzynascie zero", NumberToText.Convert(13.0M));
        }

        [TestMethod]
        public void Test_141000_23()
        {
            Assert.AreEqual("czternascie tysiecy sto dwadziescia trzy", NumberToText.Convert(14100.23M));
        }

        [TestMethod]
        public void Test_141000_230()
        {
            Assert.AreEqual("czternascie tysiecy sto dwadziescia trzy", NumberToText.Convert(14100.23M));
        }

        [TestMethod]
        public void Test_141000_23030()
        {
            Assert.AreEqual("czternascie tysiecy sto dwadziescia trzy", NumberToText.Convert(14100.23M));
        }


       
    }
}
