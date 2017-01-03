using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class ChfCurrencyDeflation : BaseCurrencyDeflation
    {
        public override Currency CurrencyCode => Currency.CHF;

        public ChfCurrencyDeflation()
            : base(
                 new[ , ]
                {
                    {"", "", ""},
                    {"frank szwajcarski", "franki szwajcarskie", "frankow szwajcarskich"},
                    {"centym", "centymy", "centymow"}
                },
                  new[ , ]
                    {
                    {"", "", ""},
                    {"frank szwajcarski", "franki szwajcarskie", "franków szwajcarskich"},
                    {"centym", "centymy", "centymów"}
                })
        {

        }
    }
}