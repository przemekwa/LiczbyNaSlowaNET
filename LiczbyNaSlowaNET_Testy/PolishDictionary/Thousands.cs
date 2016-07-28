
// Copyright (c) 2014 Przemek Walkowski

using System;

using LiczbyNaSlowaNET;
using Xunit;

namespace LiczbyNaSlowaNET_Testy
{
    
    public class Thousands 
    {
       [Fact]
        public void Test_1002()
        {
            Assert.Equal("jeden tysiac dwa", NumberToText.Convert(1002));
        }

       [Fact]
        public void Test_120030()
        {
            Assert.Equal("sto dwadziescia tysiecy trzydziesci", NumberToText.Convert(120030));
        }

       [Fact]
        public void Test_123000()
        {
            Assert.Equal("sto dwadziescia trzy tysiace", NumberToText.Convert(123000));
        }

       [Fact]
        public void Test_123032()
        {
            Assert.Equal("sto dwadziescia trzy tysiace trzydziesci dwa", NumberToText.Convert(123032));
        }

       [Fact]
        public void Test_123360()
        {
            Assert.Equal("sto dwadziescia trzy tysiace trzysta szescdziesiat", NumberToText.Convert(123360));
        }

       [Fact]
        public void Test_824702()
        {
            Assert.Equal("osiemset dwadziescia cztery tysiace siedemset dwa", NumberToText.Convert(824702));
        }

       [Fact]
        public void Test_14100()
        {
            Assert.Equal("czternascie tysiecy sto", NumberToText.Convert(14100));
        }
    }
}
