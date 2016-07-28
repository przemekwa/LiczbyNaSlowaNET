
// Copyright (c) 2014 Przemek Walkowski

using System;

using LiczbyNaSlowaNET;
using Xunit;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{
    
    public class Unity : TestBase
    {
       [Fact]
        public void Test_0()
        {
            Assert.Equal("zero", NumberToText.Convert(0));
        }

       [Fact]
        public void Test_3()
        {
            Assert.Equal("trzy", NumberToText.Convert(3));
        }
    }
}
