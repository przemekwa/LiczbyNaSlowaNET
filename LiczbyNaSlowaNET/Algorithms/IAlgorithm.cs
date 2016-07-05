
// Copyright (c) 2014 Przemek Walkowski

using System.Collections.Generic;

namespace LiczbyNaSlowaNET
{
    internal interface IAlgorithm
    {
        IEnumerable<int> Numbers { get; set; }

        IDictionaries Dictionaries { get; set; }

        NumberToTextOptions Options { get; set; }

        string Build();
    }
}
