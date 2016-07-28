using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class HufCurrencyDeflation : ICurrencyDeflation
    {
        public string CurrencyCode => "HUF";

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

        public List<string> OverrideUnity => new List<string>();

        public bool HasStems { get; set; }
    }
}
