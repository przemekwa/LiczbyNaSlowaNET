using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiczbyNaSlowaNET.Currencies
{
    public class JpyCurrencyDeflation : ICurrencyDeflation
    {
        private bool hasStems;

        public string CurrencyCode
        {
            get
            {
                return "JPY";
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

        public List<string> OverrideUnity
        {
            get
            {
                return new List<string>();
            }
        }
    }
}
