using LiczbyNaSlowaNET.Currencies;

namespace LiczbyNaSlowaNET
{
    public class NumberToTextOptions : INumberToTextOptions
    {
        private ICurrencyDeflation _currency;
        private string _splitDecimal = string.Empty;

        private IDictionaries dictionary;

        public ICurrencyDeflation Currency
        {
            get
            {
                return this._currency;
            }
            set
            {
                this._currency = value;
            }
        }

        public IDictionaries Dictionary
        {
            get { return dictionary; }
            set { dictionary = value; }
        }
        public string SplitDecimal
        {
            get
            {
                return this._splitDecimal;
            }
            set
            {
                this._splitDecimal = value;
            }
        }

        public bool WithStems
        {
            get
            {
                return Currency.HasStems;
            }
        }
    }
}