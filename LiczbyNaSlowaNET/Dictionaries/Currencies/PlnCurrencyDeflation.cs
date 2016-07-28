using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class PlnCurrencyDeflation : ICurrencyDeflation
    {
        public string CurrencyCode => "PLN";

        public string[,] GetDeflationTable
        {
            get
            {
                if (HasStems)
                {
                    return new[,]
                    {
                    {"", "", ""},
                    {"złoty", "złote", "złotych"},
                    {"grosz", "grosze", "groszy"}
                };
                }
                else
                {
                    return new[,]
                  {
                    {"", "", ""},
                    {"zloty", "zlote", "zlotych"},
                    {"grosz", "grosze", "groszy"}
                };
                }
            }
        }

        public List<string> OverrideUnity => new List<string>();

        public bool HasStems { get; set; }
    }
}