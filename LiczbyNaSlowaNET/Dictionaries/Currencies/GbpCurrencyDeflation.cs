using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiczbyNaSlowaNET.Currencies
{
    public class GbpCurrencyDeflation : ICurrencyDeflation
    {
        private bool hasStems;

        public string CurrencyCode
        {
            get
            {
                return "GBP";
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
