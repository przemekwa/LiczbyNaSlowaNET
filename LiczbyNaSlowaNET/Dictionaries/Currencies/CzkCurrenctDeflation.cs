using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class CzkCurrenctDeflation : ICurrencyDeflation, ICurrencyNotMaleDeflectionBeforeComma
    {
        public string CurrencyCode => "CZK";

        public string[,] GetDeflationTable => new[,]
        {
            {"", "", ""},
            {"korona czeska", "korony czeskie", "koron czeskich"},
            {"halerz", "halerze", "halerzy"}
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
