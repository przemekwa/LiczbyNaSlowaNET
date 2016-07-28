using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class SekCurrencyDeflation : ICurrencyDeflation, ICurrencyNotMaleDeflectionBeforeComma
    {
        public string CurrencyCode => "SEK";

        public string[,] GetDeflationTable => new[,]
        {
            {"", "", ""},
            {"korona szwedzka", "korony szwedzkie", "koron szwedzkich"},
            {"øre", "øre", "øre"}
        };

        public List<string> OverrideBeforeCommaUnity
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