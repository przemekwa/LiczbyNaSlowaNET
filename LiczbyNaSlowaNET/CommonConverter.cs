
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    internal class CommonConverter
    {
        private ConverterBuldier converterBuldier;

        public CommonConverter(ConverterBuldier converterBuldier)
        {
            if (converterBuldier == null)
            {
                throw new ArgumentNullException("converterBuldier");
            }

            this.converterBuldier = converterBuldier;
        }

        public string Convert()
        {
            return converterBuldier.Build();
        }

    }
}
