using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class NokCurrencyDeflation : BaseCurrencyDeflation, ICurrencyNotMaleDeflectionBeforeComma
    {
        public override Currency CurrencyCode => Currency.NOK;

        public NokCurrencyDeflation()
            : base(
                  new[ , ]
                {
                    {"", "", ""},
                    {"korona norweska", "korony norweskie", "koron norweskich"},
                    {"øre", "øre", "øre"} // <--- isn't this stems?
                } ,
                new[ , ]
                {
                    {"", "", ""},
                    {"korona norweska", "korony norweskie", "koron norweskich"},
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