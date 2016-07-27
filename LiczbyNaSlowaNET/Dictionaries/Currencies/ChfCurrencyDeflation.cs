using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class ChfCurrencyDeflation : ICurrencyDeflation
    {
        private bool hasStems;

        public string CurrencyCode
        {
            get { return "CHF"; }
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
                    {"frank szwajcarski", "franki szwajcarskie", "franków szwajcarskich"},
                    {"centym", "centymy", "centymów"}
                };
                }
                else
                {
                    return new[,]
                {
                    {"", "", ""},
                    {"frank szwajcarski", "franki szwajcarskie", "frankow szwajcarskich"},
                    {"centym", "centymy", "centymow"}
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