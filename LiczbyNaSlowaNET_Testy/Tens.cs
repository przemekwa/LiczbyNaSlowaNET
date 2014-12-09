
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class Tens
    {
        private Converter converter { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            this.converter = new Converter();
        }

        [TestMethod]
        public void Test_11()
        {
            Assert.AreEqual("jedenascie", converter.Convert(11));
        }

        [TestMethod]
        public void Test_13()
        {
            Assert.AreEqual("trzynascie", converter.Convert(13));
        }

        [TestMethod]
        public void Test_18()
        {
            Assert.AreEqual("osiemnascie", converter.Convert(18));
        }

        [TestMethod]
        public void Test_20()
        {
            Assert.AreEqual("dwadziescia", converter.Convert(20));
        }

        [TestMethod]
        public void Test_84()
        {
            Assert.AreEqual("osiemdziesiat cztery", converter.Convert(84));
        }
    }
}
