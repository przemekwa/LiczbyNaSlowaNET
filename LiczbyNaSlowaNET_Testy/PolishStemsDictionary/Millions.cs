
// Copyright (c) 2014 Przemek Walkowski

using System;

using LiczbyNaSlowaNET;
using Xunit;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{
    
    public class Millions : TestBase
    {
       [Fact]
        public void Test_1000000()
        {
            Assert.Equal("jeden milion", NumberToText.Convert(1000000));
        }

       [Fact]
        public void Test_123000000()
        {
            Assert.Equal("sto dwadziescia trzy miliony", NumberToText.Convert(123000000));
        }

       [Fact]
        public void Test_123000021()
        {
            Assert.Equal("sto dwadziescia trzy miliony dwadziescia jeden", NumberToText.Convert(123000021));
        }

       [Fact]
        public void Test_3200000()
        {
            Assert.Equal("trzy miliony dwiescie tysiecy", NumberToText.Convert(3200000));
        }

       [Fact]
        public void Test_13200000()
        {
            Assert.Equal("trzynascie milionow dwiescie tysiecy", NumberToText.Convert(13200000));
        }
    }
}
