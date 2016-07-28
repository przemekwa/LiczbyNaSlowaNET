using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class JpyCurrencyDeflation : ICurrencyDeflation
    {
        public string CurrencyCode => "JPY";

        public string[,] GetDeflationTable
        {
            get
            {
                if (HasStems)
                {
                    return new[,]
                   {
                    {"", "", ""},
                    {"jen", "jeny", "jenów"},
                    {"", "", ""}
                };
                }
                else
                {
                    return new[,]
                   {
                    {"", "", ""},
                    {"jen", "jeny", "jenow"},
                    {"", "", ""}
                };
                }
            }
        }

        public bool HasStems { get; set; }

        public List<string> OverrideUnity => new List<string>();
    }
}
