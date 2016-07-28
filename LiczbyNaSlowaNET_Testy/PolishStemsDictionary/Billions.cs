
// Copyright (c) 2014 Przemek Walkowski

using System;

using LiczbyNaSlowaNET;
using Xunit;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{
    
    public class Billions : TestBase
    {
       

       [Fact]
        public void Test_2000000000()
        {
            Assert.Equal("dwa miliardy", NumberToText.Convert(2000000000, this.NumberToTextOptions));
        }

       [Fact]
        public void Test_2000000006()
        {
            Assert.Equal("dwa miliardy sześć", NumberToText.Convert(2000000006, this.NumberToTextOptions));
        }

       [Fact]
        public void Test_2000000056()
        {
            Assert.Equal("dwa miliardy pięćdziesiąt sześć", NumberToText.Convert(2000000056, this.NumberToTextOptions));
        }

       [Fact]
        public void Test_2000000206()
        {
            Assert.Equal("dwa miliardy dwieście sześć", NumberToText.Convert(2000000206, this.NumberToTextOptions));
        }
    }
}
