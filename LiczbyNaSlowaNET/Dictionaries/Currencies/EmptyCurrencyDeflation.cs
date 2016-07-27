using Ninject;
using System;
using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class EmptyCurrencyDeflation : ICurrencyDeflation
    {
        bool hasStems;
        public EmptyCurrencyDeflation()
        { 
        }
        public string CurrencyCode
        {
            get { return string.Empty; }
        }

        public string[,] GetDeflationTable
        {
            get
            {
                return new[,]
                {
                    {"", "", ""},
                    {"", "", ""},
                    {"", "", ""}
                };
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