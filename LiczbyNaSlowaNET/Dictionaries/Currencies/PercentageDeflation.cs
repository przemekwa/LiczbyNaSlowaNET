using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class PercentageDeflation : ICurrencyDeflation, ICurrencyNotMaleDeflectionAfterComma
    {
        public string CurrencyCode => "PERCENT";

        public string[,] GetDeflationTable => new[,]
        {
            {"", "", ""},
            {"procent", "procenty", "procent"},
            {"setna procenta", "setne procenta", "setnych procenta"}
        };

        public List<string> OverrideAfterCommaUnity
        {
            get
            {
                if (HasStems)
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

        public bool HasStems { get; set; }
    }
}