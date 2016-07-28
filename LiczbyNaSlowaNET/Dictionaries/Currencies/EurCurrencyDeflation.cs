using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class EurCurrencyDeflation : ICurrencyDeflation
    {
        //TODO Dlaczego CurrencyCode jest typu string. Powinien być typu Currency

        public string CurrencyCode => "EUR";

        public string[,] GetDeflationTable
        {
            get
            {
                if (HasStems)
                {
                    return new[,]
                    {
                    {"", "", ""},
                    {"euro", "euro", "euro"},
                    {"cent", "centy", "centów"}
                };
                }
                else
                {
                    return new[,]
                                       {
                    {"", "", ""},
                    {"euro", "euro", "euro"},
                    {"cent", "centy", "centow"}
                };
                }
            }
        }

        public List<string> OverrideUnity => new List<string>();

        public bool HasStems { get; set; }
    }
}