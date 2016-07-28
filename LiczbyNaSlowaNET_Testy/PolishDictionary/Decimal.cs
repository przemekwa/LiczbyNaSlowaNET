
// Copyright (c) 2014 Przemek Walkowski

using System;

using LiczbyNaSlowaNET;
using Xunit;

namespace LiczbyNaSlowaNET_Testy
{
    
    public class Decimal
    {
       [Fact]
        public void Test_4_4()
        {
            Assert.Equal("cztery czterdziesci", NumberToText.Convert(4.4M));
        }

       [Fact]
        public void Test_4_40()
        {
            Assert.Equal("cztery czterdziesci", NumberToText.Convert(4.40M));
        }


       [Fact]
        public void Test_12_23()
        {
            Assert.Equal("dwanascie dwadziescia trzy", NumberToText.Convert(12.23M));
        }

       [Fact]
        public void Test_12()
        {
            Assert.Equal("dwanascie", NumberToText.Convert(12M));
        }

       [Fact]
        public void Test_0_12()
        {
            Assert.Equal("zero dwanascie", NumberToText.Convert(0.12M));
        }

       [Fact]
        public void Test_Infinity()
        {
            Assert.Equal("", NumberToText.Convert(999999999999999999999M));
        }

       [Fact]
        public void Test_13_0()
        {
            Assert.Equal("trzynascie zero", NumberToText.Convert(13.0M));
        }

       [Fact]
        public void Test_141000_23()
        {
            Assert.Equal("czternascie tysiecy sto dwadziescia trzy", NumberToText.Convert(14100.23M));
        }

       [Fact]
        public void Test_141000_230()
        {
            Assert.Equal("czternascie tysiecy sto dwadziescia trzy", NumberToText.Convert(14100.23M));
        }

       [Fact]
        public void Test_141000_23030()
        {
            Assert.Equal("czternascie tysiecy sto dwadziescia trzy", NumberToText.Convert(14100.23M));
        }


       
    }
}
