using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class NokCurrencyDeflation : ICurrencyDeflation, ICurrencyNotMaleDeflectionBeforeComma
    {
        private bool hasStems;

        public string CurrencyCode
        {
            get
            {
                return "NOK";
            }
        }

        public string[,] GetDeflationTable
        {
            get
            {
                return new[,]
             {
                    {"", "", ""},
                    {"korona norweska", "korony norweskie", "koron norweskich"},
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