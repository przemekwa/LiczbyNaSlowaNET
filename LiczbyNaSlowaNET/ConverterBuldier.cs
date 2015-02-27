
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    internal interface IConverterBuldier
    {
        int[] Numbers { get; set; }

        IDictionaries dictionaries { get;}

        string Build();
    }
}
