using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class PlnCurrencyDeflation : BaseCurrencyDeflation
    {
        public override Currency CurrencyCode => Currency.PLN;

        public PlnCurrencyDeflation()
            : base(
                  new[ , ]
                      {
                        {"", "", ""},
                        {"zloty", "zlote", "zlotych"},
                        {"grosz", "grosze", "groszy"}
                    },
                  new[ , ]
                    {
                        {"", "", ""},
                        {"złoty", "złote", "złotych"},
                        {"grosz", "grosze", "groszy"}
                    }
                  )
        {

        }
    }
}