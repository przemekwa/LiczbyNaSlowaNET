
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

        //forma gramatyczna (tysiąc, tysiące, tysięcy)
        private enum phase { beforeComma=1, afterComma  } ;

        //forma gramatyczna (tysiąc, tysiące, tysięcy)
        private phase currentNumberPhase;

        private int[] tempGrammarForm = new int[] { 2, 3, 4 };

        public override string Build()
        {
            result = new StringBuilder();
           
            this.currentNumberPhase = phase.beforeComma;

            foreach (var singleNumber in NumberToConvert)
            {
                var partialResult = new StringBuilder();

                if (singleNumber == 0)
                {
                    partialResult.Append(Dictionaries.Unity[10]).ToString();
                    partialResult.Append(" ");
                    partialResult.Append(Dictionaries.Current[(int)currentNumberPhase, 2]).ToString();
                    result.Append(partialResult.ToString().Trim());

                    result.Append(" ");
                    this.currentNumberPhase = phase.afterComma;
                    continue;
                }

                if (singleNumber < 0)
                {
                    partialResult.Append(Dictionaries.Sign[2]);
                }

                var tempNumber = singleNumber;

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
                            this.CheckWhitespace(temp)
                            );
                    }


                    this.order += 1;

                    tempNumber = tempNumber / 1000;
                }


                //partialResult.Append(this.CheckWhitespace(Dictionaries.Current[(int)this.currentNumberPhase, this.grammarForm]));

                if (this.currentNumberPhase == phase.beforeComma)
                {

                    if (singleNumber >= 5)
                    {
                        partialResult.Append(this.CheckWhitespace(Dictionaries.Current[(int)this.currentNumberPhase, 2]));
                    }
                    else if (singleNumber == 2 || singleNumber == 3 || singleNumber == 4)
                    {
                        partialResult.Append(this.CheckWhitespace(Dictionaries.Current[(int)this.currentNumberPhase, 1]));
                    }
                    else
                    {
                        partialResult.Append(this.CheckWhitespace(Dictionaries.Current[(int)this.currentNumberPhase, 0]));
                    }
                }
                else
                {
                    partialResult.Append(this.CheckWhitespace(Dictionaries.Current[(int)this.currentNumberPhase, grammarForm]));
                }



          
                

                
           

                result.Append(partialResult.ToString().Trim());

                result.Append(" ");

                this.currentNumberPhase = phase.afterComma;
            }



            return result.ToString().Trim();
            
        }

        private string CheckWhitespace(string ciag)
        {
            return String.IsNullOrEmpty(ciag) ? string.Empty : " " + ciag;
        }
    }
}
