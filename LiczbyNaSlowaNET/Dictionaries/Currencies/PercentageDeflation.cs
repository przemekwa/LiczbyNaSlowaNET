using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class PercentageDeflation : BaseCurrencyDeflation, ICurrencyNotMaleDeflectionAfterComma
    {
        public override Currency CurrencyCode => Currency.PERCENT;

        public PercentageDeflation()
            : base(
                  new[ , ]
                    {
                        {"", "", ""},
                        {"procent", "procenty", "procent"},
                        {"setna procenta", "setne procenta", "setnych procenta"}
                    } ,
                  new[ , ]
                    {
                        {"", "", ""},
                        {"procent", "procenty", "procent"},
                        {"setna procenta", "setne procenta", "setnych procenta"}
                    } )
        {

        }
        
        public List<string> GetAfterCommaUnity( bool withStems )
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