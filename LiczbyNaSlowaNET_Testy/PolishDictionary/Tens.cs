
// Copyright (c) 2014 Przemek Walkowski

using System;

using LiczbyNaSlowaNET;
using Xunit;

namespace LiczbyNaSlowaNET_Testy
{
    
    public class Tens
    {
       [Fact]
        public void Test_11()
        {
            Assert.Equal("jedenascie", NumberToText.Convert(11));
        }

       [Fact]
        public void Test_13()
        {
            Assert.Equal("trzynascie", NumberToText.Convert(13));
        }

       [Fact]
        public void Test_18()
        {
            Assert.Equal("osiemnascie", NumberToText.Convert(18));
        }

       [Fact]
        public void Test_20()
        {
            Assert.Equal("dwadziescia", NumberToText.Convert(20));
        }

       [Fact]
        public void Test_84()
        {
            Assert.Equal("osiemdziesiat cztery", NumberToText.Convert(84));
        }
    }
}
