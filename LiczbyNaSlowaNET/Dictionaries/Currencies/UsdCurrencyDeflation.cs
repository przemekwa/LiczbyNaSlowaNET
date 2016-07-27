using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class UsdCurrencyDeflation : ICurrencyDeflation
    {
        private bool hasStems;

        public string CurrencyCode
        {
            get { return "USD"; }
        }

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

        public List<string> OverrideUnity
        {
            get
            {
                return new List<string>();
            }
        }
        public bool HasStems
        {
            get
            {
                return hasStems;
            }

            set
            {
                hasStems = value;
            }
        }
    }
}