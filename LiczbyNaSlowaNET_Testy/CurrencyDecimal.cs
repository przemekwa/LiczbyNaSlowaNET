
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class CurrencyDecimal
    {
        [TestMethod]
        public void Test_Currency_12_23()
        {
            Assert.AreEqual("dwanascie zlotych dwadziescia trzy grosze", NumberToTextConverter.Convert(12.23M, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_12_02()
        {
            Assert.AreEqual("dwanascie zlotych dwa grosze", NumberToTextConverter.Convert(12.02M, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_0_12()
        {
            Assert.AreEqual("zero zlotych dwanascie groszy", NumberToTextConverter.Convert(0.12M, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_123_12()
        {
            Assert.AreEqual("sto dwadziescia trzy zlote dwanascie groszy", NumberToTextConverter.Convert(123.12M, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_Infinity()
        {
            Assert.AreEqual("", NumberToTextConverter.Convert(999999999999999999999M, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_13_0()
        {
            Assert.AreEqual("trzynascie zlotych zero groszy", NumberToTextConverter.Convert(13.0M, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_4()
        {
            Assert.AreEqual("cztery zlote", NumberToTextConverter.Convert(4, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_2()
        {
            Assert.AreEqual("dwa zlote", NumberToTextConverter.Convert(2, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_2_68()
        {
            Assert.AreEqual("dwa zlote szescdziesiat osiem groszy", NumberToTextConverter.Convert(2.68M, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_1()
        {
            Assert.AreEqual("jeden zloty", NumberToTextConverter.Convert(1, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_1_02()
        {
            Assert.AreEqual("jeden zloty dwa grosze", NumberToTextConverter.Convert(1.02M, NumberToTextConverter.Currency.PL));
        }


       [TestMethod]
        public void Test_Currency_1_22()
        {
            Assert.AreEqual("jeden zloty dwadziescia dwa grosze", NumberToTextConverter.Convert(1.22M, NumberToTextConverter.Currency.PL));
        }
        
        [TestMethod]
        public void Test_Currency_0_01()
        {
            Assert.AreEqual("zero zlotych jeden grosz", NumberToTextConverter.Convert(0.01M, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_0_20()
        {
            Assert.AreEqual("zero zlotych dwadziescia groszy", NumberToTextConverter.Convert(0.20M, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_5()
        {
            Assert.AreEqual("piec zlotych", NumberToTextConverter.Convert(5, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_3_99()
        {
            Assert.AreEqual("trzy zlote dziewiecdziesiat dziewiec groszy", NumberToTextConverter.Convert(3.99M, NumberToTextConverter.Currency.PL));
        }


        [TestMethod]
        public void Test_Currency_1000_00()
        {
            Assert.AreEqual("jeden tysiac zlotych zero groszy", NumberToTextConverter.Convert(1000.00M, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_2320_00()
        {
            Assert.AreEqual("dwa tysiace trzysta dwadziescia zlotych zero groszy", NumberToTextConverter.Convert(2320.00M, NumberToTextConverter.Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_20367_40()
        {
            Assert.AreEqual("dwadziescia tysiecy trzysta szescdziesiat siedem zlotych czterdziesci groszy", NumberToTextConverter.Convert(20367.40M, NumberToTextConverter.Currency.PL));
        }
       
    }
}
