
// Copyright (c) 2014 Przemek Walkowski

using System;

using LiczbyNaSlowaNET;
using LiczbyNaSlowaNET.Dictionaries.Currencies;
using Xunit;

namespace LiczbyNaSlowaNET_Testy
{
    
    public class SplitDecimal
    {
       [Fact]
        public void Test_SplitDecimal_50_50()
        {
            var options = new NumberToTextOptions
            {
                Currency = new EmptyCurrencyDeflation(),
                SplitDecimal = "i"
            };

            Assert.Equal("piecdziesiat i piecdziesiat", NumberToText.Convert(50.50M, options));
        }


       [Fact]
        public void Test_SplitDecimal_5_5()
        {
            var options = new NumberToTextOptions
            {
                CurrencyDeflation = Currency.PLN,
                Currency = new PlnCurrencyDeflation(),
                SplitDecimal = "i"
            };


            Assert.Equal("piec zlotych i piecdziesiat groszy", NumberToText.Convert(5.5M, options));
        }

       [Fact]
        public void Test_SplitDecimal_12_23()
        {
            var options = new NumberToTextOptions
            {
                CurrencyDeflation = Currency.PLN,
                Currency = new PlnCurrencyDeflation(),
                SplitDecimal = "i"
            };


            Assert.Equal("dwanascie zlotych i dwadziescia trzy grosze", NumberToText.Convert(12.23M, options));
        }

       [Fact]
        public void Test_SplitDecimal_12_02()
        {
            var options = new NumberToTextOptions
            {
                Currency = new PlnCurrencyDeflation(),
                CurrencyDeflation = Currency.PLN,
                SplitDecimal = " oraz "
            };

            Assert.Equal("dwanascie zlotych  oraz  dwa grosze", NumberToText.Convert(12.02M, options));
        }

       [Fact]
        public void Test_SplitDecimal_0_12()
        {
            var options = new NumberToTextOptions
            {
                Currency = new PlnCurrencyDeflation(),
                CurrencyDeflation = Currency.PLN
            };

            Assert.Equal("zero zlotych dwanascie groszy", NumberToText.Convert(0.12M, options));
        }
    }
}
