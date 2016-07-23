
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;
using LiczbyNaSlowaNET.Currencies;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class SplitDecimal
    {
        [TestMethod]
        public void Test_SplitDecimal_50_50()
        {
            var options = new NumberToTextOptions
            {
                Currency = new EmptyCurrencyDeflation(),
                SplitDecimal = "i"
            };

            Assert.AreEqual("piecdziesiat i piecdziesiat", NumberToText.Convert(50.50M, options));
        }


        [TestMethod]
        public void Test_SplitDecimal_5_5()
        {
            var options = new NumberToTextOptions
            {
                Currency = new PlnCurrencyDeflation(),
                SplitDecimal = "i"
            };


            Assert.AreEqual("piec zlotych i piecdziesiat groszy", NumberToText.Convert(5.5M, options));
        }

        [TestMethod]
        public void Test_SplitDecimal_12_23()
        {
            var options = new NumberToTextOptions
            {
                Currency = new PlnCurrencyDeflation(),
                SplitDecimal = "i"
            };


            Assert.AreEqual("dwanascie zlotych i dwadziescia trzy grosze", NumberToText.Convert(12.23M, options));
        }

        [TestMethod]
        public void Test_SplitDecimal_12_02()
        {
            var options = new NumberToTextOptions
            {
                Currency = new PlnCurrencyDeflation(),
                SplitDecimal = " oraz "
            };

            Assert.AreEqual("dwanascie zlotych  oraz  dwa grosze", NumberToText.Convert(12.02M, options));
        }

        [TestMethod]
        public void Test_SplitDecimal_0_12()
        {
            var options = new NumberToTextOptions
            {
                Currency = new PlnCurrencyDeflation(),
            };

            Assert.AreEqual("zero zlotych dwanascie groszy", NumberToText.Convert(0.12M, options));
        }
    }
}
