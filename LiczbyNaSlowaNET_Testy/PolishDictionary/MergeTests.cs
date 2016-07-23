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

            //TODO: Pomysł 3

            var test = NumberToText.Convert(2.3M, new NumberToTextOptions
            {
                Converter = Converter.ToPolsih
                CurrencySymbol = Currency.PLN,
            })


             var test = NumberToText.Convert(2.3M, new NumberToTextOptions
             {
                 Converter = Converter.ToPolishWithStems //With stems
                 CurrencySymbol = Currency.PLN,
                 SplitDecimal = ".",
             })


             var test = NumberToText.Convert(2.3M, Converter.ToPolishWithStems, CurrencySymbol = Currency.PLN);


        // TODO: Pomysł 4

        var test = NumberToText.Convert(2.3M, Converter.ToPolishWithStems);

        var test = CurrencyToText.Convert(2.3M, Converter.ToPolishWithStems, CurrencySymbol = Currency.PLN);

    }
    }
}
