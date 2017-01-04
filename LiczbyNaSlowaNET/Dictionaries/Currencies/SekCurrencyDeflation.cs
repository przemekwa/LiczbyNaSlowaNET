using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class SekCurrencyDeflation : BaseCurrencyDeflation, ICurrencyNotMaleDeflectionBeforeComma
    {
        public override Currency CurrencyCode => Currency.SEK;

        public SekCurrencyDeflation()
            : base(
                  new[ , ]
                    {
                        {"", "", ""},
                        {"korona szwedzka", "korony szwedzkie", "koron szwedzkich"},
                        {"øre", "øre", "øre"} // <--- isn't this stems?
                    },
                  new[ , ]
                    {
                        {"", "", ""},
                        {"korona szwedzka", "korony szwedzkie", "koron szwedzkich"},
                        {"øre", "øre", "øre"}
                    } )
        {

        }

        public List<string> GetBeforeCommaUnity( bool withStems )
        {
            if( withStems )
            {
                return new List<string>
                {
                    "","jedna","dwie" , "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć","zero"
                };
            }
            else
            {
                return new List<string>
                {
                    "","jedna","dwie" , "trzy", "cztery", "piec", "szesc", "siedem", "osiem", "dziewiec","zero"
                };
            }
        }
    }
}