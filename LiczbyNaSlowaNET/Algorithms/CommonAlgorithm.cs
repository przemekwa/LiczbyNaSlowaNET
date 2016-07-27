
// Copyright (c) 2014 Przemek Walkowski

using LiczbyNaSlowaNET.Dictionaries;

namespace LiczbyNaSlowaNET.Algorithms
{
    using System.Linq;
    using System.Text;

    internal sealed class CommonAlgorithm : Algorithm
    {
        public CommonAlgorithm(IDictionaries dictionary) :
           base(dictionary)
        {

        }

        private readonly StringBuilder result = new StringBuilder();

        private int hundreds;
      
        private int tens;

        private int unity;

        private int othersTens;

        private int order;

        private int grammarForm;

        private phase currentPhase;

        private readonly int[] tempGrammarForm = new int[] { 2, 3, 4 };

        public override string Build()
        {
            this.currentPhase = phase.beforeComma;

            foreach (var number in Numbers)
            {
                var partialResult = new StringBuilder();

                if (number == 0)
                {
                    partialResult.Append(Dictionaries.Unity[10]);

                    this.currentPhase = phase.afterComma;
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

                if (this.currentPhase == phase.beforeComma && !string.IsNullOrEmpty(Options.SplitDecimal))
                {
                    result.Append(Options.SplitDecimal);
                    result.Append(" ");
                }

                this.currentPhase = phase.afterComma;
            }

            return result.ToString().Trim();
            
        }
    }
}
