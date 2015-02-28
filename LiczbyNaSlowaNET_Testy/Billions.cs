
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class Billions
    {
        [TestMethod]
        public void Test_2000000000()
        {
            Assert.AreEqual("dwa miliardy", NumberToText.Convert(2000000000));
        }

        [TestMethod]
        public void Test_2000000006()
        {
            Assert.AreEqual("dwa miliardy szesc", NumberToText.Convert(2000000006));
        }

        [TestMethod]
        public void Test_2000000056()
        {
            Assert.AreEqual("dwa miliardy piecdziesiat szesc", NumberToText.Convert(2000000056));
        }

        [TestMethod]
        public void Test_2000000206()
        {
            Assert.AreEqual("dwa miliardy dwiescie szesc", NumberToText.Convert(2000000206));
        }
    }
}
