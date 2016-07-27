using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class EurCurrencyDeflation : ICurrencyDeflation
    {
        private bool hasStems;

        public string CurrencyCode
        {
            get { return "EUR"; }
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