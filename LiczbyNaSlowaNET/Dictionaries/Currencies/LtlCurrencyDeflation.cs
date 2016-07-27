using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class LtlCurrencyDeflation : ICurrencyDeflation
    {
        private bool hasStems;

        public string CurrencyCode
        {
            get
            {
                return "LTL";
            }
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
                    {"lit litewski", "lity litewskie", "litów litewskich"},
                    {"cent", "centy", "centów"}
                };
                }
                else
                {
                    return new[,]
                   {
                    {"", "", ""},
                    {"lit litewski", "lity litewskie", "litow litewskich"},
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
