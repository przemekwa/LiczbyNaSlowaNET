using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LiczbyNaSlowaNET;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{
    public abstract class TestBase
    {
        public NumberToTextOptions NumberToTextOptions { get; set; } = new NumberToTextOptions { Dictionary = new PolishWithsStemsDictionary() };
    }
}
