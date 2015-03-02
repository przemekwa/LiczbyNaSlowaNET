
// Copyright (c) 2014 Przemek Walkowski

using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    internal enum phase { beforeComma = 1, afterComma };

    internal sealed class CurrencyAlgorithm : IAlgorithm
    {
        private StringBuilder result = new StringBuilder();
       
        private int hundreds;
                
        private int tens;

        private int unity;

        private int othersTens;

        private int order;

        private phase currentPhase;

        private int[] tempGrammarForm = new int[] { 2, 3, 4 };

        public IEnumerable<int> Numbers { get; set; }

        public NumberToTextOptions Options { get; set; }

        [Inject]
        public IDictionaries Dictionaries { get; set; }

        public string Build()
        {
            int grammarForm = 0;

            this.currentPhase = phase.beforeComma;

            foreach (var number in Numbers)
            {
                var partialResult = new StringBuilder();

                if (number == 0)
                {
                    partialResult.Append(Dictionaries.Unity[10]).ToString();
                    partialResult.Append(" ");

                    partialResult.Append(Dictionaries.Current[(int)currentPhase, 2]).ToString();

                    result.Append(partialResult.ToString().Trim());

                    result.Append(" ");

                    this.currentPhase = phase.afterComma;

                    continue;
                   
                }

                if (number < 0)
                {
                    partialResult.Append(Dictionaries.Sign[2]);
                }

                var tempNumber = number;

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

                    grammarForm = this.GetGrammaForm();
                    

                    if ((this.hundreds + this.unity + this.othersTens + this.tens) > 0)
                    {
                        var tempPartialResult = partialResult.ToString().Trim();

                        partialResult.Clear();

                        partialResult.AppendFormat("{0}{1}{2}{3}{4}{5}",
                            this.CheckWhitespace(Dictionaries.Hundreds[this.hundreds]),
                            this.CheckWhitespace(Dictionaries.Tens[this.tens]),
                            this.CheckWhitespace(Dictionaries.OthersTens[this.othersTens]),
                            this.CheckWhitespace(Dictionaries.Unity[this.unity]),
                            this.CheckWhitespace(Dictionaries.Endings[this.order, grammarForm]),
                            this.CheckWhitespace(tempPartialResult));
                    }

                    this.order += 1;

                    tempNumber = tempNumber / 1000;
                }

                partialResult.Append(this.CheckWhitespace(Dictionaries.Current[(int)this.currentPhase, GetCurrencyForm(number)]));

                result.Append(partialResult.ToString().Trim());

                result.Append(" ");

                if (this.currentPhase == phase.beforeComma && !string.IsNullOrEmpty(Options.SplitDecimal))
                {
                    result.Append(Options.SplitDecimal);
                    result.Append(" ");
                }
               

                this.currentPhase = phase.afterComma;
            }

            return result.ToString().Trim();
        }

        private string CheckWhitespace(string ciag)
        {
            return String.IsNullOrEmpty(ciag) ? string.Empty : " " + ciag;
        }

        private int GetCurrencyForm(int number)
        {
            var hundreds = (number % 1000) / 100;

            var tens = (number % 100) / 10;

            var unity = number % 10;

                if (unity == 1 && (hundreds + tens + othersTens == 0))
                {
                    return 0;
                }
                else if (tempGrammarForm.Contains(unity) && tens != 1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
        }

        private int GetGrammaForm()
        {
            if (this.unity == 1 && (this.hundreds + this.tens + this.othersTens == 0))
            {
                return  0;
            }
            else if (tempGrammarForm.Contains(this.unity))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        
    }
}
