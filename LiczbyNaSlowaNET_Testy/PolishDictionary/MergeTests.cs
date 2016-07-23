using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LiczbyNaSlowaNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiczbyNaSlowaNET_Testy.PolishDictionary
{
    [TestClass]
    public class MergeTests
    {
        [TestMethod]
        public void NewWay()
        {
            // TODO: Pomysł 1

            var test = NumberToText.Convert(2.3M, new NumberToTextOptions
            {
                Dictionary = new PolishWithsStemsDictionary();
            });

        //TODO: Pomysł 2

            var test = NumberToText.Convert(2.3M, new NumberToTextOptions
            {
                Converter = Converter.PL
            })


             var test = NumberToText.Convert(2.3M, new NumberToTextOptions
             {
                 Converter = Converter.PL2 //With stems
             })


            var test = NumberToText.Convert(2.3M, new NumberToTextOptions
            {
                Converter = Converter.PL
                CurrencySymbol = Currency.PLN,
            })


             var test = NumberToText.Convert(2.3M, new NumberToTextOptions
             {
                 Converter = Converter.PL2 //With stems
                 CurrencySymbol = Currency.PLN,
                 SplitDecimal = ".",
             })


        }
    }
}
