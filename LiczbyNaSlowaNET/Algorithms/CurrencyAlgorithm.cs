
// Copyright (c) 2014 Przemek Walkowski

namespace LiczbyNaSlowaNET.Algorithms
{
    using System.Linq;
    using System.Text;

    using Dictionaries.Currencies;
    using Dictionaries;
    using System.Collections.Generic;
    internal sealed class CurrencyAlgorithm : Algorithm
    {
        public CurrencyAlgorithm(IDictionaries dictionary, ICurrencyDeflation currencyDeflation, string splitDecimal, bool stems ) :
           base(dictionary, currencyDeflation, splitDecimal, stems)
        { }

        private readonly StringBuilder result = new StringBuilder();
       
        private readonly long[] tempGrammarForm = { 2, 3, 4 };

        public override string Build( IEnumerable<long> numbers )
        {
            var currentPhase = DeflationPhraseType.BeforeComma;

            foreach (var number in numbers )
            {
                var partialResult = new StringBuilder();

                if (number == 0)
                {
                    partialResult.Append(dictionary.Unity[10]);

                    partialResult.Append(" ");

                    partialResult.Append( currencyDeflation.GetDeflationPhrase( currentPhase, 2, withStems ) );

                    result.Append(partialResult.ToString().Trim());

                    result.Append(" ");

                    currentPhase = DeflationPhraseType.AfterComma;

                    continue;
                   
                }

                if (number < 0)
                {
                    partialResult.Append(dictionary.Sign[2]);
                }

                var tempNumber = number;

                int order = 0;
                int hundreds = 0, tens = 0, unity = 0, othersTens = 0, sumAboveUnity = 0;

                while (tempNumber != 0)
                {
                    hundreds = (int)( ( tempNumber % 1000 ) / 100 );
                    tens = (int)( ( tempNumber % 100 ) / 10 );
                    unity = (int)( tempNumber % 10 );
                    othersTens = 0;

                    if ( tens == 1 && unity > 0)
                    {
                        othersTens = unity;
                        tens = 0;
                        unity = 0;
                    }
                    else
                    {
                        othersTens = 0;
                    }

                    sumAboveUnity = hundreds + tens + othersTens;
                    var grammarForm = this.GetGrammarForm( unity, sumAboveUnity );
                    

                    if ((unity + sumAboveUnity) > 0)
                    {
                        var tempPartialResult = partialResult.ToString().Trim();

                        partialResult.Clear();
                        var properUnity = dictionary.Unity;

                        if (currentPhase == DeflationPhraseType.AfterComma && currencyDeflation is ICurrencyNotMaleDeflectionAfterComma && tens == 0)
                        {
                            properUnity = ( currencyDeflation as ICurrencyNotMaleDeflectionAfterComma ).GetAfterCommaUnity( withStems );
                        }

                        if (currentPhase == DeflationPhraseType.BeforeComma && currencyDeflation is ICurrencyNotMaleDeflectionBeforeComma)
                        {
                            properUnity = ( currencyDeflation as ICurrencyNotMaleDeflectionBeforeComma ).GetBeforeCommaUnity( withStems );
                        }

                        partialResult.AppendFormat( "{0}{1}{2}{3}{4}{5}",
                            this.SetSpaceBeforeString( dictionary.Hundreds[ hundreds ] ),
                            this.SetSpaceBeforeString( dictionary.Tens[ tens ] ),
                            this.SetSpaceBeforeString( dictionary.OthersTens[ othersTens ] ),
                            this.SetSpaceBeforeString( properUnity[ unity ] ),
                            this.SetSpaceBeforeString( dictionary.Endings[ order, grammarForm ] ),
                            this.SetSpaceBeforeString( tempPartialResult ) );
                    }

                    order += 1;

                    tempNumber = tempNumber / 1000;
                }

                // hm we are using here some variables (unity, tens, sumabove) that are modified inside above while loop and only there
                // and yet we are using them here, outside loop. It would be better if we could use them only inside while loop...
                partialResult.Append( this.SetSpaceBeforeString(
                    currencyDeflation.GetDeflationPhrase( currentPhase, GetCurrencyForm( number, othersTens ), withStems ) ) );

                result.Append(partialResult.ToString().Trim());

                result.Append(" ");

                if (currentPhase == DeflationPhraseType.BeforeComma && !string.IsNullOrEmpty( splitDecimal ))
                {
                    result.Append(splitDecimal);
                    result.Append(" ");
                }

                currentPhase = DeflationPhraseType.AfterComma;
            }

            return result.ToString().Trim();
        }

        // maybe this should be moved to dictionary classes?
        private int GetCurrencyForm( long number, int othersTens )
        {
            var hundreds = ( number % 1000 ) / 100;

            var tens = ( number % 100 ) / 10;

            var unity = number % 10;

            if( unity == 1 && ( hundreds + tens + othersTens == 0 ) )
            {
                return 0;
            }

            if (tempGrammarForm.Contains(unity) && tens != 1)
            {
                return 1;
            }

            return 2;
        }

        // maybe this should be moved to dictionary classes?
        private int GetGrammarForm( int unity, int sumAboveUnity )
        {
            if ( unity == 1 && sumAboveUnity == 0)
                return  0;

            if (tempGrammarForm.Contains( unity ) )
                return 1;

            return 2;
        }
    }
}
