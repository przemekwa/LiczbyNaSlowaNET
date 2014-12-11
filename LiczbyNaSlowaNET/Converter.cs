
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    public static class Converter
    {
        private static  ConverterAlgorithm convertAlgorithm;

        static Converter()
        {
            convertAlgorithm = new ConverterAlgorithm();

        }
        /// <summary>
        /// Convert number to words. 
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>The words describe number</returns>
        public static string Convert(int number)
        {
            convertAlgorithm.NumberToConvert = number;

            var commonConverter = new CommonConverter(convertAlgorithm);

            return commonConverter.Convert();
        }
    }
}
