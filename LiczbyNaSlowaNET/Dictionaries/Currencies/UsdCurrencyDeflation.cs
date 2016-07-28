using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class UsdCurrencyDeflation : ICurrencyDeflation
    {
        public string CurrencyCode => "USD";

        public string[,] GetDeflationTable
        {
            get
            {
                if (HasStems)
                {
                    return new[,]
                    {
                    {"", "", ""},
                    {"dolar", "dolary", "dolarów"},
                    {"cent", "centy", "centów"}
                };
                }
                else
                {
                    return new[,]
                   {
                    {"", "", ""},
                    {"dolar", "dolary", "dolarow"},
                    {"cent", "centy", "centow"}
                };
                }
            }
        }

        public List<string> OverrideUnity => new List<string>();

        public bool HasStems { get; set; }
    }
}