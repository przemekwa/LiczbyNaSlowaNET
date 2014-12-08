
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    internal class AlgorytmZamiany
    {
        private LiczbyNaSlowaBuldier liczbyNaSlowaBuldier;

        public AlgorytmZamiany(LiczbyNaSlowaBuldier liczbyNaSlowaBuldier)
        {
            if (liczbyNaSlowaBuldier == null)
            {
                throw new ArgumentNullException("LiczbyNaSlowaBuldier");
            }

            this.liczbyNaSlowaBuldier = liczbyNaSlowaBuldier;
        }

        public string ZamienNaSlowa()
        {
            return liczbyNaSlowaBuldier.Build();
        }

    }
}
