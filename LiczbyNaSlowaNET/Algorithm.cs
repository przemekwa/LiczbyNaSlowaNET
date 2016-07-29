
// Copyright (c) 2014 Przemek Walkowski

namespace LiczbyNaSlowaNET
{
    using System.Collections.Generic;

    using Algorithms;
    using Dictionaries;

    internal abstract class Algorithm : IAlgorithm
    {
        public IDictionaries Dictionaries { get; set; }

        public IEnumerable<int> Numbers { get; set; }

        public NumberToTextOptions Options { get; set; }

        protected Algorithm(IDictionaries dictionary)
        {
            this.Dictionaries = dictionary;
        }

        public abstract string Build();

        public virtual string SetSpaceBeforeString(string @string)
        {
            return string.IsNullOrEmpty(@string) ? string.Empty : " " + @string;
        }
    }
}