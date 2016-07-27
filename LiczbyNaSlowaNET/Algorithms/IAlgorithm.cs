
// Copyright (c) 2014 Przemek Walkowski

using LiczbyNaSlowaNET.Dictionaries;

namespace LiczbyNaSlowaNET.Algorithms
{
    using System.Collections.Generic;

    internal interface IAlgorithm
    {
        IEnumerable<int> Numbers { get; set; }

        IDictionaries Dictionaries { get; set; }

        NumberToTextOptions Options { get; set; }

        string Build();
    }
}
