using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiczbyNaSlowaNET.Currencies
{
    public class CzkCurrenctDeflation : ICurrencyDeflation, ICurrencyNotMaleDeflectionBeforeComma
    {
        private bool hasStems;

        public string CurrencyCode
        {
            get
            {
                return "CZK";
            }
        }

        public string[,] GetDeflationTable
        {
            get
            {
                return new[,]
               {
                    {"", "", ""},
                    {"korona czeska", "korony czeskie", "koron czeskich"},
                    {"halerz", "halerze", "halerzy"}
                };
            }
        }

        public List<string> OverrideBeforeCommaUnity
        {
            get
            {
                if (HasStems)
                {
                    return new List<string>
                {
                    "","jedna","dwie" , "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć","zero"
                };
                }
                else
                {
                    return new List<string>
                {
                    "","jedna","dwie" , "trzy", "cztery", "piec", "szesc", "siedem", "osiem", "dziewiec","zero"
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

    }
}
