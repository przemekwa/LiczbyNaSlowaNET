
// Copyright (c) 2014 Przemek Walkowski

using Ninject;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    public static class NumberToText
    {
        public enum Currency { None, PL };

        private static IKernel kernel;

        static NumberToText()
        {
            kernel = new StandardKernel();

            kernel.Bind(typeof(IDictionaries)).To<Dictionaries>();
            kernel.Bind<CommonAlgorithm>().ToSelf();
            kernel.Bind<CurrencyAlgorithm>().ToSelf();
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

            return CommonConver(allNumbers, currency);
        }

        private static string CommonConver(IEnumerable<int> numbers, Currency currency)
        {
            var algorithm = GetAlgorithm(currency);

            algorithm.Numbers = numbers;

            return algorithm.Build();
        }

        private static IAlgorithm GetAlgorithm(Currency currency)
        {
           switch (currency)
            {
                case Currency.PL:
                    return kernel.Get<CurrencyAlgorithm>();
                default:
                    return kernel.Get<CommonAlgorithm>();
            }
        }

    }
}
