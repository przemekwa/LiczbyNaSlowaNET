
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{
    [TestClass]
    public class Billions : TestBase
    {
       

        [TestMethod]
        public void Test_2000000000()
        {
            Assert.AreEqual("dwa miliardy", NumberToText.Convert(2000000000, this.NumberToTextOptions));
        }

        [TestMethod]
        public void Test_2000000006()
        {
            Assert.AreEqual("dwa miliardy sześć", NumberToText.Convert(2000000006, this.NumberToTextOptions));
        }

        [TestMethod]
        public void Test_2000000056()
        {
            Assert.AreEqual("dwa miliardy pięćdziesiąt sześć", NumberToText.Convert(2000000056, this.NumberToTextOptions));
        }

        [TestMethod]
        public void Test_2000000206()
        {
            Assert.AreEqual("dwa miliardy dwieście sześć", NumberToText.Convert(2000000206, this.NumberToTextOptions));
        }
    }
}
