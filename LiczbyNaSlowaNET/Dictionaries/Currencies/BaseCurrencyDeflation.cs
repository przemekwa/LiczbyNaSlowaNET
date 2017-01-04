using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public abstract class BaseCurrencyDeflation : ICurrencyDeflation
    {
        public abstract Currency CurrencyCode { get; }

        protected readonly string[,] noStemsPhrases;
        protected readonly string[,] withStemsPhrases;

        protected BaseCurrencyDeflation( string[,] noStemsPhrases, string[,] withStemsPhrases )
        {
            this.noStemsPhrases = noStemsPhrases;
            this.withStemsPhrases = withStemsPhrases;
        }

        public virtual string GetDeflationPhrase( DeflationPhraseType phraseType, int grammarForm, bool withStems )
        {
            if (withStems)
            {
                return withStemsPhrases[(int) phraseType, grammarForm];
            }

            return noStemsPhrases[(int) phraseType, grammarForm];
        }

    }
}
