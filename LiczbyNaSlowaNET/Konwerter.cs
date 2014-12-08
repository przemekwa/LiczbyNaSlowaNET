
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    public class Konwerter
    {
        public string ZamienNaSlowa(int liczba)
        {
            var buldier = new LiczbyNaSlowa
            {
                Liczba = liczba
            };

            var zamiana = new AlgorytmZamiany(buldier);

            return zamiana.ZamienNaSlowa();
        }
    }
}
