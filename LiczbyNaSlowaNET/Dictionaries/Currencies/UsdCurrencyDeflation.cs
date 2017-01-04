using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class UsdCurrencyDeflation : BaseCurrencyDeflation
    {
        public override Currency CurrencyCode => Currency.USD;

        public UsdCurrencyDeflation()
            :base( new[ , ]
                   {
                    {"", "", ""},
                    {"dolar", "dolary", "dolarow"},
                    {"cent", "centy", "centow"}
                },
                new[ , ]
                    {
                    {"", "", ""},
                    {"dolar", "dolary", "dolarów"},
                    {"cent", "centy", "centów"}
                } )
        {

        }
    }
}