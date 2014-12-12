
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    public static class NumberToTextConverter
    {
        private static  ConverterAlgorithm convertAlgorithm;

        static NumberToTextConverter()
        {
            convertAlgorithm = new ConverterAlgorithm();
        }
        
        /// <summary>
        /// Convert number into words. 
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>The words describe number</returns>
        public static string Convert(int number)
        {
            convertAlgorithm.NumberToConvert = number;

            var commonConverter = new CommonConverter(convertAlgorithm);

            return commonConverter.Convert();
        }

        public static string Convert(decimal number)
        {
            var result = new StringBuilder();

            var splitNumber = number.ToString().Replace('.','@').Replace(',','@').Split('@');

            foreach (var singleNumber in splitNumber)
            {
                int intNumber;

                if (!int.TryParse(singleNumber, out intNumber))
                {
                    return String.Empty;
                }

                 result.Append(Convert(intNumber));
                 result.Append(" ");
            }

            return result.ToString().Trim();
        }
    }
}
