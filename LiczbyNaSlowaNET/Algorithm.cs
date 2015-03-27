using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiczbyNaSlowaNET
{
    abstract class Algorithm : IAlgorithm
    {
        public IDictionaries Dictionaries { get; set; }

        public IEnumerable<int> Numbers { get; set; }

        public NumberToTextOptions Options { get; set; }

        public Algorithm(IDictionaries dictionary)
        {
            this.Dictionaries = dictionary;
        }

        public abstract string Build();
    }
}
