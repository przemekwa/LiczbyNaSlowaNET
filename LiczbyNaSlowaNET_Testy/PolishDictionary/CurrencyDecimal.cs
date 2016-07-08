
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
        public void Test_Currency_6_416()
        {
            Assert.AreEqual("szesc zloty czterdziesci dwa grosze", NumberToText.Convert(6.416M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_6_414()
        {
            Assert.AreEqual("szesc zloty czterdziesci jeden groszy", NumberToText.Convert(6.414M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_6_400()
        {
            Assert.AreEqual("szesc zloty czterdziesci groszy", NumberToText.Convert(6.400M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_4_4()
        {
            Assert.AreEqual("cztery zlote czterdziesci groszy", NumberToText.Convert(4.4M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_4_40()
        {
            Assert.AreEqual("cztery zlote czterdziesci groszy", NumberToText.Convert(4.40M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_12_23()
        {
            Assert.AreEqual("dwanascie zlotych dwadziescia trzy grosze", NumberToText.Convert(12.23M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_12_02()
        {
            Assert.AreEqual("dwanascie zlotych dwa grosze", NumberToText.Convert(12.02M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_0_12()
        {
            Assert.AreEqual("zero zlotych dwanascie groszy", NumberToText.Convert(0.12M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_123_12()
        {
            Assert.AreEqual("sto dwadziescia trzy zlote dwanascie groszy", NumberToText.Convert(123.12M, Currency.PL));
        }


        [TestMethod]
        public void Test_Currency_125_12()
        {
            Assert.AreEqual("sto dwadziescia piec zlotych dwanascie groszy", NumberToText.Convert(125.12M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_126_12()
        {
            Assert.AreEqual("sto dwadziescia szesc zlotych dwanascie groszy", NumberToText.Convert(126.12M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_23_12()
        {
            Assert.AreEqual("dwadziescia trzy zlote dwanascie groszy", NumberToText.Convert(23.12M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_Infinity()
        {
            Assert.AreEqual("", NumberToText.Convert(999999999999999999999M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_13_0()
        {
            Assert.AreEqual("trzynascie zlotych zero groszy", NumberToText.Convert(13.0M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_2594()
        {
            Assert.AreEqual("dwa tysiace piecset dziewiecdziesiat cztery zlote", NumberToText.Convert(2594, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_4()
        {
            Assert.AreEqual("cztery zlote", NumberToText.Convert(4, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_2()
        {
            Assert.AreEqual("dwa zlote", NumberToText.Convert(2, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_2_68()
        {
            Assert.AreEqual("dwa zlote szescdziesiat osiem groszy", NumberToText.Convert(2.68M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_1()
        {
            Assert.AreEqual("jeden zloty", NumberToText.Convert(1, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_1_02()
        {
            Assert.AreEqual("jeden zloty dwa grosze", NumberToText.Convert(1.02M, Currency.PL));
        }


       [TestMethod]
        public void Test_Currency_1_22()
        {
            Assert.AreEqual("jeden zloty dwadziescia dwa grosze", NumberToText.Convert(1.22M, Currency.PL));
        }
        
        [TestMethod]
        public void Test_Currency_0_01()
        {
            Assert.AreEqual("zero zlotych jeden grosz", NumberToText.Convert(0.01M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_0_20()
        {
            Assert.AreEqual("zero zlotych dwadziescia groszy", NumberToText.Convert(0.20M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_5()
        {
            Assert.AreEqual("piec zlotych", NumberToText.Convert(5, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_3_99()
        {
            Assert.AreEqual("trzy zlote dziewiecdziesiat dziewiec groszy", NumberToText.Convert(3.99M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_999_00()
        {
            Assert.AreEqual("dziewiecset dziewiecdziesiat dziewiec zlotych zero groszy", NumberToText.Convert(999.00M, Currency.PL));
        }


        [TestMethod]
        public void Test_Currency_1000_00()
        {
            Assert.AreEqual("jeden tysiac zlotych zero groszy", NumberToText.Convert(1000.00M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_2320_00()
        {
            Assert.AreEqual("dwa tysiace trzysta dwadziescia zlotych zero groszy", NumberToText.Convert(2320.00M, Currency.PL));
        }
        
        [TestMethod]
        public void Test_Currency_2596()
        {
            Assert.AreEqual("dwa tysiace piecset dziewiecdziesiat szesc zlotych", NumberToText.Convert(2596, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_20367_40()
        {
            Assert.AreEqual("dwadziescia tysiecy trzysta szescdziesiat siedem zlotych czterdziesci groszy", NumberToText.Convert(20367.40M, Currency.PL));
        }

        [TestMethod]
        public void Test_Currency_20367_45()
        {
            Assert.AreEqual("dwadziescia tysiecy trzysta szescdziesiat siedem zlotych czterdziesci piec groszy", NumberToText.Convert(20367.45M, Currency.PL));
        }

    }
}
