
// Copyright (c) 2014 Przemek Walkowski

using System;

using LiczbyNaSlowaNET;
using Xunit;

namespace LiczbyNaSlowaNET_Testy
{
    
    public class Billions
    {
       [Fact]
        public void Test_2000000000()
        {
            Assert.Equal("dwa miliardy", NumberToText.Convert(2000000000));
        }

       [Fact]
        public void Test_2000000006()
        {
            Assert.Equal("dwa miliardy szesc", NumberToText.Convert(2000000006));
        }

       [Fact]
        public void Test_2000000056()
        {
            Assert.Equal("dwa miliardy piecdziesiat szesc", NumberToText.Convert(2000000056));
        }

       [Fact]
        public void Test_2000000206()
        {
            Assert.Equal("dwa miliardy dwiescie szesc", NumberToText.Convert(2000000206));
        }
    }
}
