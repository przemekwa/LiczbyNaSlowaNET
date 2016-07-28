using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class LtlCurrencyDeflation : ICurrencyDeflation
    {
        public string CurrencyCode => "LTL";

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

        public List<string> OverrideUnity => new List<string>();

        public bool HasStems { get; set; }
    }
}
