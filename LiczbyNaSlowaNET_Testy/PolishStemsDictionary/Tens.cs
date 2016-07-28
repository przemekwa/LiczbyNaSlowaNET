
// Copyright (c) 2014 Przemek Walkowski

using System;

using LiczbyNaSlowaNET;
using Xunit;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{
    
    public class Tens : TestBase
    {
       [Fact]
        public void Test_11()
        {
            Assert.Equal("jedenaście", NumberToText.Convert(11, this.NumberToTextOptions));
        }

       [Fact]
        public void Test_13()
        {
            Assert.Equal("trzynaście", NumberToText.Convert(13, this.NumberToTextOptions));
        }

       [Fact]
        public void Test_18()
        {
            Assert.Equal("osiemnaście", NumberToText.Convert(18, this.NumberToTextOptions));
        }

       [Fact]
        public void Test_20()
        {
            Assert.Equal("dwadzieścia", NumberToText.Convert(20, this.NumberToTextOptions));
        }

       [Fact]
        public void Test_84()
        {
            Assert.Equal("osiemdziesiąt cztery", NumberToText.Convert(84, this.NumberToTextOptions));
        }
    }
}
