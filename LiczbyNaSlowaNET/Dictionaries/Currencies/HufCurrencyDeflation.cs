using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class HufCurrencyDeflation : BaseCurrencyDeflation
    {
        public override Currency CurrencyCode => Currency.HUF;

        public HufCurrencyDeflation()
            : base(
                  new[ , ]
                                {
                    {"", "", ""},
                    {"forint", "forinty", "forintow"},
                    {"", "", ""}
                },
                new[ , ]
                                  {
                    {"", "", ""},
                    {"forint", "forinty", "forintów"},
                    {"", "", ""}
                } )
        {

        }
    }
}
