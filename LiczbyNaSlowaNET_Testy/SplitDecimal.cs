
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class SplitDecimal
    {
        [TestMethod]
        public void Test_SplitDecimal_12_23()
        {
            var options = new NumberToTextOptions
            {
                curency = Currency.PL,
                SplitDecimal = "i"
            };


            Assert.AreEqual("dwanascie zlotych i dwadziescia trzy grosze", NumberToText.Convert(12.23M, options));
        }

        [TestMethod]
        public void Test_SplitDecimal_12_02()
        {
            var options = new NumberToTextOptions
            {
                curency = Currency.PL,
                SplitDecimal = " oraz "
            };

            Assert.AreEqual("dwanascie zlotych  oraz  dwa grosze", NumberToText.Convert(12.02M, options));
        }

        [TestMethod]
        public void Test_SplitDecimal_0_12()
        {
            var options = new NumberToTextOptions
            {
                curency = Currency.PL,
            };

            Assert.AreEqual("zero zlotych dwanascie groszy", NumberToText.Convert(0.12M, options));
        }
    }
}
