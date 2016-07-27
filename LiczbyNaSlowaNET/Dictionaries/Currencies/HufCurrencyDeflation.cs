using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class HufCurrencyDeflation : ICurrencyDeflation
    {
        private bool hasStems;

        public string CurrencyCode
        {
            get
            {
                return "HUF";
            }
        }

        public string[,] GetDeflationTable
        {
            get
            {
                if(HasStems)
                {
                    return new[,]
                                  {
                    {"", "", ""},
                    {"forint", "forinty", "forintów"},
                    {"", "", ""}
                };
                }
                else
                {
                    return new[,]
                                {
                    {"", "", ""},
                    {"forint", "forinty", "forintow"},
                    {"", "", ""}
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
