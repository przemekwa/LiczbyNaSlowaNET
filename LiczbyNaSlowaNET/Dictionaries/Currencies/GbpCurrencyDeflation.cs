using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class GbpCurrencyDeflation : ICurrencyDeflation
    {
        public string CurrencyCode => "GBP";

        public string[,] GetDeflationTable
        {
            get
            {
                if (HasStems)
                {
                    return new[,]
                   {
                    {"", "", ""},
                    {"funt brytyjski", "funty brytyjskie", "funtów brytyjskich"},
                    {"pens", "pensy", "pensów"}
                };
                }
                else
                {
                    return new[,]
                                     {
                    {"", "", ""},
                    {"funt brytyjski", "funty brytyjskie", "funtow brytyjskich"},
                    {"pens", "pensy", "pensow"}
                };
                }
            }
        }

        public List<string> OverrideUnity => new List<string>();

        public bool HasStems { get; set; }
    }
}
