
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class Unity
    {
        [TestMethod]
        public void Test_0()
        {
            Assert.AreEqual("zero", NumberToTextConverter.Convert(0));
        }

        [TestMethod]
        public void Test_3()
        {
            Assert.AreEqual("trzy", NumberToTextConverter.Convert(3));
        }
    }
}
