
// Copyright (c) 2014 Przemek Walkowski

using System;

using LiczbyNaSlowaNET;
using Xunit;

namespace LiczbyNaSlowaNET_Testy
{
    
    public class CurrencyDecimal
    {
       [Fact]
        public void Test_Currency_6_466()
        {
            Assert.Equal("szesc zlotych czterdziesci siedem groszy", NumberToText.Convert(6.466M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_6_414()
        {
            Assert.Equal("szesc zlotych czterdziesci jeden groszy", NumberToText.Convert(6.414M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_6_400()
        {
            Assert.Equal("szesc zlotych czterdziesci groszy", NumberToText.Convert(6.400M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_4_4()
        {
            Assert.Equal("cztery zlote czterdziesci groszy", NumberToText.Convert(4.4M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_4_40()
        {
            Assert.Equal("cztery zlote czterdziesci groszy", NumberToText.Convert(4.40M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_12_23()
        {
            Assert.Equal("dwanascie zlotych dwadziescia trzy grosze", NumberToText.Convert(12.23M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_12_02()
        {
            Assert.Equal("dwanascie zlotych dwa grosze", NumberToText.Convert(12.02M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_0_12()
        {
            Assert.Equal("zero zlotych dwanascie groszy", NumberToText.Convert(0.12M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_123_12()
        {
            Assert.Equal("sto dwadziescia trzy zlote dwanascie groszy", NumberToText.Convert(123.12M, Currency.PLN));
        }


       [Fact]
        public void Test_Currency_125_12()
        {
            Assert.Equal("sto dwadziescia piec zlotych dwanascie groszy", NumberToText.Convert(125.12M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_126_12()
        {
            Assert.Equal("sto dwadziescia szesc zlotych dwanascie groszy", NumberToText.Convert(126.12M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_23_12()
        {
            Assert.Equal("dwadziescia trzy zlote dwanascie groszy", NumberToText.Convert(23.12M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_Infinity()
        {
            Assert.Equal("", NumberToText.Convert(999999999999999999999M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_13_0()
        {
            Assert.Equal("trzynascie zlotych zero groszy", NumberToText.Convert(13.0M, Currency.PLN));
        }

        [Fact]
        public void Test_Currency_EUR_13_0()
        {
            Assert.Equal("trzynascie euro zero centow", NumberToText.Convert(13.0M, Currency.EUR));
        }

        [Fact]
        public void Test_Currency_2594()
        {
            Assert.Equal("dwa tysiace piecset dziewiecdziesiat cztery zlote", NumberToText.Convert(2594, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_4()
        {
            Assert.Equal("cztery zlote", NumberToText.Convert(4, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_2()
        {
            Assert.Equal("dwa zlote", NumberToText.Convert(2, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_2_68()
        {
            Assert.Equal("dwa zlote szescdziesiat osiem groszy", NumberToText.Convert(2.68M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_1()
        {
            Assert.Equal("jeden zloty", NumberToText.Convert(1, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_1_02()
        {
            Assert.Equal("jeden zloty dwa grosze", NumberToText.Convert(1.02M, Currency.PLN));
        }


      [Fact]
        public void Test_Currency_1_22()
        {
            Assert.Equal("jeden zloty dwadziescia dwa grosze", NumberToText.Convert(1.22M, Currency.PLN));
        }
        
       [Fact]
        public void Test_Currency_0_01()
        {
            Assert.Equal("zero zlotych jeden grosz", NumberToText.Convert(0.01M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_0_20()
        {
            Assert.Equal("zero zlotych dwadziescia groszy", NumberToText.Convert(0.20M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_5()
        {
            Assert.Equal("piec zlotych", NumberToText.Convert(5, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_3_99()
        {
            Assert.Equal("trzy zlote dziewiecdziesiat dziewiec groszy", NumberToText.Convert(3.99M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_999_00()
        {
            Assert.Equal("dziewiecset dziewiecdziesiat dziewiec zlotych zero groszy", NumberToText.Convert(999.00M, Currency.PLN));
        }


       [Fact]
        public void Test_Currency_1000_00()
        {
            Assert.Equal("jeden tysiac zlotych zero groszy", NumberToText.Convert(1000.00M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_2320_00()
        {
            Assert.Equal("dwa tysiace trzysta dwadziescia zlotych zero groszy", NumberToText.Convert(2320.00M, Currency.PLN));
        }
        
       [Fact]
        public void Test_Currency_2596()
        {
            Assert.Equal("dwa tysiace piecset dziewiecdziesiat szesc zlotych", NumberToText.Convert(2596, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_20367_40()
        {
            Assert.Equal("dwadziescia tysiecy trzysta szescdziesiat siedem zlotych czterdziesci groszy", NumberToText.Convert(20367.40M, Currency.PLN));
        }

       [Fact]
        public void Test_Currency_20367_45()
        {
            Assert.Equal("dwadziescia tysiecy trzysta szescdziesiat siedem zlotych czterdziesci piec groszy", NumberToText.Convert(20367.45M, Currency.PLN));
        }

    }
}
