using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiczbyNaSlowaNET
{
    using Dictionaries;
    using Dictionaries.Currencies;

    internal class NumberToTextOptionBuilder
    {
        private NumberToTextOptions numberToTextOptions = new NumberToTextOptions();

        public NumberToTextOptions Build(NumberToTextOptions options = null)
        {
            if (options != null)
            {
                numberToTextOptions = options;
            }

            SetDeflation();
            SetDictionary();

            return numberToTextOptions;
        }


        private  void SetDeflation()
        {
            numberToTextOptions.Currency = numberToTextOptions.Currency ??
                new CurrencyDeflationFactory(numberToTextOptions.Stems).CreateInstance(numberToTextOptions.CurrencyDeflation.ToString());
        }

        private  void SetDictionary()
        {
            numberToTextOptions.Dictionary = numberToTextOptions.Dictionary ?? new PolishDictionary();
        }
    }
}
