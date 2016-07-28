using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class NokCurrencyDeflation : ICurrencyDeflation, ICurrencyNotMaleDeflectionBeforeComma
    {
        public string CurrencyCode => "NOK";

        public string[,] GetDeflationTable => new[,]
        {
            {"", "", ""},
            {"korona norweska", "korony norweskie", "koron norweskich"},
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