
// Copyright (c) 2014 Przemek Walkowski

using System;

using LiczbyNaSlowaNET;
using Xunit;

namespace LiczbyNaSlowaNET_Testy
{
    
    public class Hundreds
    {
       [Fact]
        public void Test_123()
        {
            Assert.Equal("sto dwadziescia trzy", NumberToText.Convert(123));
        }

       [Fact]
        public void Test_403()
        {
            Assert.Equal("czterysta trzy", NumberToText.Convert(403));
        }

       [Fact]
        public void Test_320()
        {
            Assert.Equal("trzysta dwadziescia", NumberToText.Convert(320));
        }

       [Fact]
        public void Test_700()
        {
            Assert.Equal("siedemset", NumberToText.Convert(700));
        }

       [Fact]
        public void Test_999()
        {
            Assert.Equal("dziewiecset dziewiecdziesiat dziewiec", NumberToText.Convert(999));
        }
    }
}
