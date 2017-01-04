
// Copyright (c) 2014 Przemek Walkowski

namespace LiczbyNaSlowaNET
{
    using System;
    using System.Collections.Generic;

    using Algorithms;
    using Dictionaries;
    using Dictionaries.Currencies;
    internal abstract class Algorithm : IAlgorithm
    {
        protected readonly ICurrencyDictionary dictionary;
        protected readonly ICurrencyDeflation currencyDeflation;
        protected readonly string splitDecimal;
        protected readonly bool withStems;
        
        protected Algorithm(ICurrencyDictionary dictionary, ICurrencyDeflation currencyDeflation, string splitDecimal, bool withStems )
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            if (currencyDeflation == null)
            {
                throw new ArgumentNullException(nameof(currencyDeflation));
            }

            this.dictionary = dictionary;
            this.currencyDeflation = currencyDeflation;
            this.splitDecimal = splitDecimal;
            this.withStems = withStems;
        }

        public abstract string Build( IEnumerable<long> numbers );

        protected virtual string SetSpaceBeforeString(string @string)
        {
            return string.IsNullOrEmpty(@string) ? string.Empty : " " + @string;
        }
    }
}