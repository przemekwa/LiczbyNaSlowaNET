
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    abstract class LiczbyNaSlowaBuldier
    {
        public int Liczba { get; set; }

        abstract public string Build();
    }
}
