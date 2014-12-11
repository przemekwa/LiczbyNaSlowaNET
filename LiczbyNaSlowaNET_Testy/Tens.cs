
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class Tens
    {
        [TestMethod]
        public void Test_11()
        {
            Assert.AreEqual("jedenascie", NumberToTextConverter.Convert(11));
        }

        [TestMethod]
        public void Test_13()
        {
            Assert.AreEqual("trzynascie", NumberToTextConverter.Convert(13));
        }

        [TestMethod]
        public void Test_18()
        {
            Assert.AreEqual("osiemnascie", NumberToTextConverter.Convert(18));
        }

        [TestMethod]
        public void Test_20()
        {
            Assert.AreEqual("dwadziescia", NumberToTextConverter.Convert(20));
        }

        [TestMethod]
        public void Test_84()
        {
            Assert.AreEqual("osiemdziesiat cztery", NumberToTextConverter.Convert(84));
        }
    }
}
