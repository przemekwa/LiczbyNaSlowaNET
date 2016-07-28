
// Copyright (c) 2014 Przemek Walkowski

namespace LiczbyNaSlowaNET
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    using Algorithms;
    using Dictionaries;
    using Dictionaries.Currencies;
    using Ninject;
    using Ninject.Extensions.Conventions;

    internal enum Phase { BeforeComma = 1, AfterComma };

    public enum Currency
    {
        NONE,
        PLN,
        CHF,
        CZK,
        EUR,
        HUF,
        JPY,
        LTL,
        NOK,
        SEK,
        USD
    }

    public static class NumberToText
    {
        private static IKernel _kernel;

        static NumberToText()
        {
            _kernel = new StandardKernel();

            _kernel.Bind(typeof(IDictionaries)).To<PolishDictionary>();
            _kernel.Bind<CommonAlgorithm>().ToSelf();
            _kernel.Bind<CurrencyAlgorithm>().ToSelf();
            _kernel.Bind<NumberToTextOptions>().ToSelf();
            _kernel.Bind<ICurrencyDeflationFactory>().To<CurrencyDeflationFactory>().WithConstructorArgument("withStems",_kernel.Get<IDictionaries>().HasStems);
            _kernel.Bind(x => x.FromAssemblyContaining<ICurrencyDeflation>().SelectAllClasses().InheritedFrom<ICurrencyDeflation>().BindAllInterfaces());
        }


        /// <summary>
        /// Convert (int) number into words.
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <param name="currency">Currency of number</param>
        /// <returns>he words describe number</returns>
        public static string Convert(int number, Currency currency)
        {
            var options = _kernel.Get<NumberToTextOptions>();

            ConvertToICurrenctyDeflation(currency, options);

            return CommonConvert(new int[] { number }, options);
        }

        public static string Convert(int number, NumberToTextOptions options)
        {
            return CommonConvert(new int[] { number }, options);
        }

        public static string Convert(decimal number, Currency currency = Currency.NONE)
        {
            var options = _kernel.Get<NumberToTextOptions>();

            ConvertToICurrenctyDeflation(currency, options);

            return CommonConvert(PrepareNumbers(number), options);
        }

        public static string Convert(decimal number, NumberToTextOptions options)
        {
            return CommonConvert(PrepareNumbers(number), options);
        }
        
        private static string CommonConvert(IEnumerable<int> numbers, NumberToTextOptions options)
        {
            var algorithm = GetAlgorithm(options.Currency);

            algorithm.Dictionaries = options.Dictionary ?? _kernel.Get<IDictionaries>(); 
            algorithm.Numbers = numbers;
            algorithm.Options = options;

            return algorithm.Build();
        }

        private static IAlgorithm GetAlgorithm(ICurrencyDeflation currency)
        {
            //TODO Ten kawałek jest nie przetestowany. CurrencyCode nie mozemy być typu string.

            if (currency.CurrencyCode.Equals("NONE"))
            {
                return _kernel.Get<CommonAlgorithm>();
            }

            return _kernel.Get<CurrencyAlgorithm>();
        }

        private static IEnumerable<int> PrepareNumbers(decimal numbers)
       {
            var splitNumber = Math.Round(numbers, 2).ToString(CultureInfo.InvariantCulture).Replace('.', '@').Replace(',', '@').Split('@');

            if (splitNumber.Length > 1 && splitNumber[1].Length == 1)
            {
                splitNumber[1] += "0";
            }
            
            var allNumbers = new List<int>();

            foreach (var t in splitNumber)
            {
                int intNumber;

                if (int.TryParse(t, out intNumber))
                {
                    allNumbers.Add(intNumber);
                }
            }

            return allNumbers;
        }

        private static void ConvertToICurrenctyDeflation(Currency currency, INumberToTextOptions options)
        {
            options.Currency = _kernel.Get<ICurrencyDeflationFactory>().CreateInstance(currency.ToString());
        }

        /// <summary>
        /// Converts decimal number with currency, based on currency ISO code
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <param name="currencyCode">Currency Code as given in ISO 4217</param>
        /// <returns></returns>
        public static string Convert(decimal number, string currencyCode)
        {
            var options = _kernel.Get<NumberToTextOptions>();
            options.Currency = _kernel.Get<ICurrencyDeflationFactory>().CreateInstance(currencyCode);
            return CommonConvert(PrepareNumbers(number), options);
        }
        /// <summary>
        /// Converts integer number with currency, based on currency ISO code
        /// </summary>
        /// <param name="number">Integer to convert</param>
        /// <param name="currencyCode">Currency code asgiven in ISO 4217</param>
        /// <returns></returns>
        public static string Convert(int number, string currencyCode)
        {
            var options = _kernel.Get<NumberToTextOptions>();
            options.Currency = _kernel.Get<ICurrencyDeflationFactory>().CreateInstance(currencyCode);
            return CommonConvert(PrepareNumbers(number), options);
        }

        /// <summary>
        /// Returns list of defined/available currencies
        /// </summary>
        public static List<ICurrencyDeflation> DefinedCurrencies => _kernel.Get<CurrencyDeflationFactory>().CurrencyList;
    }
}
