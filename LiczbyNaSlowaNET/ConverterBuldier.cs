
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    public abstract class ConverterBuldier
    {
        public int NumberToConvert { get; set; }

        abstract public string Build();
    }
}
