using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Currencies
{
    public class SekCurrencyDeflation : ICurrencyDeflation, ICurrencyNotMaleDeflectionBeforeComma
    {
        private bool hasStems;

        public string CurrencyCode
        {
            get
            {
                return "SEK";
            }
        }

        public string[,] GetDeflationTable
        {
            get
            {
                return new[,]
                {
                    {"", "", ""},
                    {"korona szwedzka", "korony szwedzkie", "koron szwedzkich"},
                    {"øre", "øre", "øre"}
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