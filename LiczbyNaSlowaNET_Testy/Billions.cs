
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class Billions
    {
        private Converter converter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.converter = new Converter();
        }
     
        [TestMethod]
        public void Test_2000000000()
        {
            Assert.AreEqual("dwa miliardy", converter.Convert(2000000000));
        }

        [TestMethod]
        public void Test_2000000006()
        {
            Assert.AreEqual("dwa miliardy szesc", converter.Convert(2000000006));
        }

        [TestMethod]
        public void Test_2000000056()
        {
            Assert.AreEqual("dwa miliardy piecdziesiat szesc", converter.Convert(2000000056));
        }

        [TestMethod]
        public void Test_2000000206()
        {
            Assert.AreEqual("dwa miliardy dwiescie szesc", converter.Convert(2000000206));
        }
    }
}
