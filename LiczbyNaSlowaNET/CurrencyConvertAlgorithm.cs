
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    internal class CurrencyConvertAlgorithm : ConverterBuldier
    {
        private StringBuilder result;

        // liczba setek
        private int hundreds;

        //liczba dziesiątek
        private int tens;

        //liczba jedności
        private int unity;

        //liczba nastek (11,12,13 itd)
        private int othersTens;

        //rząd wielkości (tysiąc, milion, miliard)
        private int order;

        //forma gramatyczna (tysiąc, tysiące, tysięcy)
        private int grammarForm;
        
        public override string Build()
        {
            result = new StringBuilder();

            if (this.NumberToConvert == 0)
            {
                return result.Append(Dictionaries.Unity[10]).ToString();
            }

            if (this.NumberToConvert < 0)
            {
                result.Append(Dictionaries.Sign[2]);
            }

            var tempNumber = this.NumberToConvert;

            this.order = 0;
            
            while (tempNumber != 0)
            {
                this.hundreds = (tempNumber % 1000) / 100;

                this.tens = (tempNumber % 100) / 10;

                this.unity = tempNumber % 10;

                if (this.tens == 1 && this.unity > 0)
                {
                    this.othersTens = this.unity;
                    this.tens = 0;
                    this.unity = 0;
                }
                else
                {
                    this.othersTens = 0;
                }

                var tempGrammarForm = new int[] { 2, 3, 4 };


                if (this.unity == 1 && (this.hundreds + this.tens + this.othersTens == 0))
                {
                    this.grammarForm = 0;
                }
                else if (tempGrammarForm.Contains(this.unity))
                {
                    this.grammarForm = 1;
                }
                else
                {
                    this.grammarForm = 2;
                }

                if ((this.hundreds + this.unity + this.othersTens + this.tens) > 0)
                {
                    var temp = result.ToString().Trim();

                    result.Clear();

                    result.AppendFormat("{0}{1}{2}{3}{4}{5}",
                        this.CheckWhitespace(Dictionaries.Hundreds[this.hundreds]),
                        this.CheckWhitespace(Dictionaries.Tens[this.tens]),
                        this.CheckWhitespace(Dictionaries.OthersTens[this.othersTens]),
                        this.CheckWhitespace(Dictionaries.Unity[this.unity]),
                        this.CheckWhitespace(Dictionaries.Endings[this.order, this.grammarForm]),
                        this.CheckWhitespace(Dictionaries.Current[1, 2]),
                        this.CheckWhitespace(temp));
                }
              
                this.order += 1;

                tempNumber = tempNumber / 1000;
            }

            return result.ToString().Trim();
            
        }

        private string CheckWhitespace(string ciag)
        {
            return String.IsNullOrEmpty(ciag) ? string.Empty : " " + ciag;
        }
    }
}
