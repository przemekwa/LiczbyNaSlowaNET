namespace LiczbyNaSlowaNET
{
    public class NumberToTextOptions
    {
        private Currency _currency = Currency.None;
        private string _splitDecimal = string.Empty;

        private IDictionaries dictionary;

        public IDictionaries Dictionary
        {
            get { return dictionary; }
            set { dictionary = value; }
        }


        public Currency curency 
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

    }
}
