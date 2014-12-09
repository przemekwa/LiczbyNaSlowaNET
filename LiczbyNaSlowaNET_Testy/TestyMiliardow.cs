
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class TestyMiliardow
    {
        private Konwerter konwerter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.konwerter = new Konwerter();
        }
     
        [TestMethod]
        public void Test_2000000000()
        {
            Assert.AreEqual("dwa miliardy", konwerter.ZamienNaSlowa(2000000000));
        }

        [TestMethod]
        public void Test_2000000006()
        {
            Assert.AreEqual("dwa miliardy szesc", konwerter.ZamienNaSlowa(2000000006));
        }

        [TestMethod]
        public void Test_2000000056()
        {
            Assert.AreEqual("dwa miliardy piecdziesiat szesc", konwerter.ZamienNaSlowa(2000000056));
        }

        [TestMethod]
        public void Test_2000000206()
        {
            Assert.AreEqual("dwa miliardy dwiescie szesc", konwerter.ZamienNaSlowa(2000000206));
        }
    }
}
