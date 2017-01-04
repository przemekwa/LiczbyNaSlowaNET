using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class EurCurrencyDeflation : BaseCurrencyDeflation
    {
        public override Currency CurrencyCode => Currency.EUR;

        public EurCurrencyDeflation()
            : base(
            new[,]
                {
                    {"", "", ""},
                    {"euro", "euro", "euro"},
                    {"cent", "centy", "centow"}
                },
            new[,]
                    {
                    {"", "", ""},
                    {"euro", "euro", "euro"},
                    {"cent", "centy", "centów"}
                })

        {

        }
    }
}