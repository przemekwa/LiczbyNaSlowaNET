using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class ChfCurrencyDeflation : ICurrencyDeflation
    {
        public string CurrencyCode => "CHF";

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

        public List<string> OverrideUnity => new List<string>();

        public bool HasStems { get; set; }
    }
}