
// Copyright (c) 2014 Przemek Walkowski

namespace LiczbyNaSlowaNET.Algorithms
{
    using System.Collections.Generic;

    using Dictionaries;

    internal interface IAlgorithm
    {
        IEnumerable<int> Numbers { get; set; }

        IDictionaries Dictionaries { get; set; }

        NumberToTextOptions Options { get; set; }

        string Build();
    }
}
