using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiczbyNaSlowaNET
{
    public class NumberToTextOptions
    {
        private Currency _currency = Currency.None;
        private string _splitDecimal = string.Empty;

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
