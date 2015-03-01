
// Copyright (c) 2014 Przemek Walkowski

using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    internal sealed class CommonAlgorithm : IAlgorithm
    {
        private StringBuilder result = new StringBuilder();

        private int hundreds;
      
        private int tens;

        private int unity;

        private int othersTens;

        private int order;

        private int grammarForm;

        private int[] tempGrammarForm = new int[] { 2, 3, 4 };

        [Inject]
        public IDictionaries Dictionaries { get; set; }

        public IEnumerable<int> Numbers { get; set; }

        public NumberToTextOptions Options { get; set; }

        public string Build()
        {
            foreach (var number in Numbers)
            {
                var partialResult = new StringBuilder();

                if (number == 0)
                {
                    partialResult.Append(Dictionaries.Unity[10]).ToString();
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
                        var temp = partialResult.ToString().Trim();

                        partialResult.Clear();

                        partialResult.AppendFormat("{0}{1}{2}{3}{4}{5}",
                            this.CheckWhitespace(Dictionaries.Hundreds[this.hundreds]),
                            this.CheckWhitespace(Dictionaries.Tens[this.tens]),
                            this.CheckWhitespace(Dictionaries.OthersTens[this.othersTens]),
                            this.CheckWhitespace(Dictionaries.Unity[this.unity]),
                            this.CheckWhitespace(Dictionaries.Endings[this.order, this.grammarForm]),                  
                            this.CheckWhitespace(temp));
                    }

                    this.order += 1;

                    tempNumber = tempNumber / 1000;
                }

                result.Append(partialResult.ToString().Trim());

                result.Append(" ");

                if (!(number == Numbers.Last()) && !string.IsNullOrEmpty(Options.SplitDecimal))
                {
                    result.Append(Options.SplitDecimal);
                    result.Append(" ");
                }
            }

            return result.ToString().Trim();
            
        }

        private string CheckWhitespace(string ciag)
        {
            return String.IsNullOrEmpty(ciag) ? string.Empty : " " + ciag;
        }
    }
}
