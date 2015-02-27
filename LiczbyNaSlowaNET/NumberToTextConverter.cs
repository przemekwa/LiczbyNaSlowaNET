
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
        public enum Currency { None, PL };

        private static ConverterBuldier Initialization(Currency currency)
        {
            switch (currency)
            {
                case Currency.PL:
                    return new CurrencyConvertAlgorithm();
                default:
                    return new ConverterAlgorithm();
            }
        }

        private static string CommonConver(int[] numbers, Currency currency = Currency.None)
        {
            var converterBuldier = Initialization(currency);

            converterBuldier.Numbers = numbers;

            var commonConverter = new CommonConverter(converterBuldier);

            return commonConverter.Convert();
        }

        /// <summary>
        /// Convert number into words.
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>The words describe number</returns>
        public static string Convert(int number, Currency currency)
        {
            return CommonConver(new int[] { number }, currency);
        }

        public static string Convert(decimal number, Currency currency = Currency.None)
        {
            var result = new StringBuilder();

            var splitNumber = number.ToString().Replace('.','@').Replace(',','@').Split('@');

            var allNumbers = new List<int>();

            for (int i = 0; i < splitNumber.Length; i++)
            {
                int intNumber;

                if (int.TryParse(splitNumber[i], out intNumber))
                {
                    allNumbers.Add(intNumber);
                }
            }

            return CommonConver(allNumbers.ToArray(), currency);
        }
    }
}
