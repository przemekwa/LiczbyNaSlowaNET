using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public class CurrencyDeflationFactory : ICurrencyDeflationFactory
    {
        private readonly List<string> availableCurrencyDeflations = new List<string>();
        private bool withStems;
        public CurrencyDeflationFactory(bool withStems)
        {
            CurrencyList = new List<ICurrencyDeflation>
            {
                new PlnCurrencyDeflation(),
                new ChfCurrencyDeflation(),
                new CzkCurrenctDeflation(),
                new EmptyCurrencyDeflation(),
                new EurCurrencyDeflation(),
                new GbpCurrencyDeflation(),
                new HufCurrencyDeflation(),
                new JpyCurrencyDeflation(),
                new LtlCurrencyDeflation(),
                new NokCurrencyDeflation(),
                new LtlCurrencyDeflation(),
                new PercentageDeflation(),
                new UsdCurrencyDeflation(),
                new SekCurrencyDeflation(),
            };

            this.withStems = withStems;
        }

        public List<string> AvailableCurrencyDeflations
        {
            get
            {
                availableCurrencyDeflations.Clear();
                foreach (var item in CurrencyList)
                {
                    availableCurrencyDeflations.Add(item.CurrencyCode);
                }
                return availableCurrencyDeflations;
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