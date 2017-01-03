
// Copyright (c) 2014 Przemek Walkowski

namespace LiczbyNaSlowaNET
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    using Algorithms;
    using Dictionaries;
    using Dictionaries.Currencies;
    using System.Linq;

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
        USD,
        GBP,
        PERCENT
    }

    public static class NumberToText
    {
        /// <summary>
        /// Convert (int) number into words.
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <param name="currency">Currency of number</param>
        /// <returns>he words describe number</returns>
        public static string Convert(int number, Currency currency = Currency.NONE, bool stems = false )
        {
            return Convert( (long)number, currency, stems );
        }

        public static string Convert( long number, Currency currency = Currency.NONE, bool stems = false )
        {
            var options = new NumberToTextOptions
            {
                Stems = stems,
                Currency = currency,
            };

            return CommonConvert( new[] { number }, options );
        }

        public static string Convert(decimal number, Currency currency = Currency.NONE, bool stems = false )
        {
            var options = new NumberToTextOptions
            {
                Stems = stems,
                Currency = currency,
            };

            return CommonConvert(PrepareNumbers(number), options);
        }

        public static string Convert(int number, NumberToTextOptions options)
        {
            return Convert( (long)number, options );
        }

        public static string Convert( long number, NumberToTextOptions options )
        {
            return CommonConvert( new[] { number }, options );
        }

        public static string Convert(decimal number, NumberToTextOptions options)
        {
            return CommonConvert(PrepareNumbers(number), options);
        }

        private static string CommonConvert(IEnumerable<long> numbers, NumberToTextOptions options)
        {
            // create proper currency deflation according to options
            var currencyDeflation = CurrencyDeflationFactory.GetCurrencyDeflation( options.Currency );
            // get dictionary or default
            var dictionary = options.Dictionary ?? new PolishDictionary();
            // create algorithm
            var algorithm = new CurrencyAlgorithm( dictionary, currencyDeflation, options.SplitDecimal, options.Stems );
            // convert!
            return algorithm.Build( numbers );
        }

        private static IEnumerable<long> PrepareNumbers(decimal numbers)
        { 
            var splitNumber = Math.Round(numbers, 2).ToString(CultureInfo.InvariantCulture).Replace('.', '@').Replace(',', '@').Split('@');

            if (splitNumber.Length > 1 && splitNumber[1].Length == 1)
            {
                splitNumber[1] += "0"; // why like that? :)
            }

            var allNumbers = new List<long>( splitNumber.Length );

            foreach (var t in splitNumber)
            {
                long nb;
                if ( long.TryParse(t, out nb))
                    allNumbers.Add(nb);
            }

            return allNumbers;
        }
    }
}
