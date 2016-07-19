using System;
using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Currencies
{
    public class CurrencyDeflationFactory : ICurrencyDeflationFactory
    {
        private readonly List<string> _availableCurrencyDeflations = new List<string>();
        private bool withStems;
        public CurrencyDeflationFactory(List<ICurrencyDeflation> definedDeflations,bool withStems)
        {
            CurrencyList = definedDeflations;
            this.withStems = withStems;
        }

        public List<string> AvailableCurrencyDeflations
        {
            get
            {
                _availableCurrencyDeflations.Clear();
                foreach (var item in CurrencyList)
                {
                    _availableCurrencyDeflations.Add(item.CurrencyCode);
                }
                return _availableCurrencyDeflations;
            }
        }

        public List<ICurrencyDeflation> CurrencyList { get; }

        public ICurrencyDeflation CreateInstance(string currencyCode)
        {
            var currencyInstance = CurrencyList.Find(x => x.CurrencyCode.Equals(currencyCode));
            currencyInstance.HasStems = this.withStems;
            return currencyInstance;
        }
 
    }
}