
// Copyright (c) 2016 Przemek Walkowski

using System;
using System.Collections.Generic;

namespace LiczbyNaSlowaNET
{
    public class PolishWithsStemsDictionary : IDictionaries
    {
        public PolishWithsStemsDictionary()
        {
            unity = new List<string>
                {
                    "","jeden","dwa" , "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć","zero"
                };

            othersTens = new List<string>
                {
                    "","jedenaście", "dwanaście","trzynaście" , "czternaście", "pietnaście", "szesnaście", "siedemnaście", "osiemnaście", "dziewietnaście"
                };

            tens = new List<string>
                {
                    "","dziesięc", "dwadzieścia","trzydzieści" , "czterdzieści", "piędziesiąt", "sześćdziesiąt", "siedemdziesiąt", "osiemdziesiąt", "dziewięćdziesiąt"
                };

            hundreds = new List<string>
                {
                    "","sto", "dwieście","trzysta" , "czterysta", "pięćset", "sześćset", "siedemset", "osiemset", "dziewięćset"
                };

            endings = new string[,]
            {
                {"","",""},
                {"tysiac","tysiace","tysiecy"},
                {"milion","miliony","milionow"},
                {"miliard","miliardy","miliardow"},
                {"bilion","biliony","bilionow"},
                {"biliard","biliardy","biliardow"}
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
        }

        private string[,] endings;

        private List<String> unity;

        private List<String> othersTens;

        private List<String> tens;

        private List<String> hundreds;

        private List<String> sign;

        private string[,] current;


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
    }
}



