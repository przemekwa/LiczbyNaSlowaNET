
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class TestyDziesiatek
    {
        private Converter konwerter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.konwerter = new Converter();
        }

        [TestMethod]
        public void Test_11()
        {
            Assert.AreEqual("jedenascie", konwerter.Convert(11));
        }

        [TestMethod]
        public void Test_13()
        {
            Assert.AreEqual("trzynascie", konwerter.Convert(13));
        }

        [TestMethod]
        public void Test_18()
        {
            Assert.AreEqual("osiemnascie", konwerter.Convert(18));
        }

        [TestMethod]
        public void Test_20()
        {
            Assert.AreEqual("dwadziescia", konwerter.Convert(20));
        }

        [TestMethod]
        public void Test_84()
        {
            Assert.AreEqual("osiemdziesiat cztery", konwerter.Convert(84));
        }
    }
}
