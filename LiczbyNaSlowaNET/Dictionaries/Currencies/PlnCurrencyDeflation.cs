using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class PlnCurrencyDeflation : ICurrencyDeflation
    {
        private bool hasStems;

        public string CurrencyCode
        {
            get { return "PLN"; }
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