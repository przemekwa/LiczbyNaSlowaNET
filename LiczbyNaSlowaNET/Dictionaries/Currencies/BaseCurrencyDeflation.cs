using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public abstract class BaseCurrencyDeflation : ICurrencyDeflation
    {
        public abstract Currency CurrencyCode { get; }

        // hm we could probably have only one phrases table - with stems - and create no stems table from that
        protected readonly string[,] noStemsPhrases;
        protected readonly string[,] withStemsPhrases;

        protected BaseCurrencyDeflation( string[,] noStemsPhrases, string[,] withStemsPhrases )
        {
            this.noStemsPhrases = noStemsPhrases;
            this.withStemsPhrases = withStemsPhrases;
        }

        public virtual string GetDeflationPhrase( DeflationPhraseType phraseType, int grammarForm, bool withStems )
        {
            if( withStems )
                return withStemsPhrases[ (int)phraseType, grammarForm ];
            else
                return noStemsPhrases[ (int)phraseType, grammarForm ];
        }

    }
}
