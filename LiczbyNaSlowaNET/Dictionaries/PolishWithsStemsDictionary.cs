
// Copyright (c) 2016 Przemek Walkowski

namespace LiczbyNaSlowaNET.Dictionaries
{
    using System;
    using System.Collections.Generic;

    using Currencies;

    public class PolishWithsStemsDictionary : IDictionaries
    {
        public PolishWithsStemsDictionary(List<ICurrencyDeflation> currencyDeflation)
        {
            unity = new List<string>
                {
                    "","jeden","dwa" , "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć","zero"
                };

            othersTens = new List<string>
                {
                    "","jedenaście", "dwanaście","trzynaście" , "czternaście", "piętnaście", "szesnaście", "siedemnaście", "osiemnaście", "dziewiętnaście"
                };

            tens = new List<string>
                {
                    "","dziesięć", "dwadzieścia","trzydzieści" , "czterdzieści", "pięćdziesiąt", "sześćdziesiąt", "siedemdziesiąt", "osiemdziesiąt", "dziewięćdziesiąt"
                };

            hundreds = new List<string>
                {
                    "","sto", "dwieście","trzysta" , "czterysta", "pięćset", "sześćset", "siedemset", "osiemset", "dziewięćset"
                };

            endings = new string[,]
            {
                 {"","",""},
                {"tysiąc","tysiące","tysięcy"},
                {"milion","miliony","milionów"},
                {"miliard","miliardy","miliardów"},
                {"bilion","biliony","bilionów"},
                {"biliard","biliardy","biliardów"}
            };

            sign = new List<string>
            {
                "plus", "minus"
            };

            current = new string[,]
            {
                {"","",""},
                {"złoty","złote","złotych"},
                {"grosz","grosze","groszy"}
            };
            currency = currencyDeflation;
        }

        private string[,] endings;

        private List<String> unity;

        private List<String> othersTens;

        private List<String> tens;

        private List<String> hundreds;

        private List<String> sign;

        private string[,] current;

        private readonly List<ICurrencyDeflation> currency;

        private bool hasStems =true;

        public List<String> Unity
        {
            get
            {
                return unity;
            }
        }

        public List<String> OthersTens
        {
            get
            {
                return othersTens;
            }
        }

        public List<String> Tens
        {
            get
            {
                return tens;
            }
        }

        public List<String> Hundreds
        {
            get
            {
                return hundreds;
            }
        }

        public string[,] Endings
        {
            get
            {
                return endings;
            }
        }

        public List<String> Sign
        {
            get
            {
                return sign;
            }
        }

        public string[,] Current
        {
            get
            {
                return current;
            }
        }

        public List<ICurrencyDeflation> Currency
        {
            get
            {
                return currency;
            }
        }

        public bool HasStems
        {
            get
            {
                return hasStems;
            }
        }
    }
}