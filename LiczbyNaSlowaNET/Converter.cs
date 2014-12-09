
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    public class Converter
    {
        private ConverterAlgorithm convertAlgorithm;

        public Converter()
        {
            this.convertAlgorithm = new ConverterAlgorithm();

        }
        /// <summary>
        /// Convert number to words. 
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>The words describe number</returns>
        public string Convert(int number)
        {
            this.convertAlgorithm.NumberToConvert = number;

            var commonConverter = new CommonConverter(this.convertAlgorithm);

            return commonConverter.Convert();
        }
    }
}
