﻿
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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