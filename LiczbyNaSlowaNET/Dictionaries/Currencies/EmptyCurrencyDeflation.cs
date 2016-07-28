using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class EmptyCurrencyDeflation : ICurrencyDeflation
    {
        public EmptyCurrencyDeflation()
        { 
        }
        public string CurrencyCode => string.Empty;

        public string[,] GetDeflationTable => new[,]
        {
            {"", "", ""},
            {"", "", ""},
            {"", "", ""}
        };

        public bool HasStems { get; set; }

        public List<string> OverrideUnity => new List<string>();
    }
}