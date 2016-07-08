using System;
using System.Collections.Generic;

namespace LiczbyNaSlowaNET
{
    abstract class Algorithm : IAlgorithm
    {
        public IDictionaries Dictionaries { get; set; }

        public IEnumerable<int> Numbers { get; set; }

        public NumberToTextOptions Options { get; set; }

        public abstract string Build();

        public virtual string CheckWhitespace(string ciag)
        {
            return String.IsNullOrEmpty(ciag) ? string.Empty : " " + ciag;
        }
    }
}
