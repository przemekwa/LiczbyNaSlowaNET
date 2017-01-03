using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LiczbyNaSlowaNET;
using LiczbyNaSlowaNET.Dictionaries;
using LiczbyNaSlowaNET.Dictionaries.Currencies;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{
    public abstract class TestBase
    {
        protected NumberToTextOptions NumberToTextOptions { get; set; } = new NumberToTextOptions
        {
            Dictionary = new PolishWithsStemsDictionary(new List<ICurrencyDeflation>()
            {
                new EmptyCurrencyDeflation()
            }), Currency = new EmptyCurrencyDeflation()
        };
    }
}
