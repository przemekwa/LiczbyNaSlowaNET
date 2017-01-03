
// Copyright (c) 2016 Przemek Walkowski

namespace LiczbyNaSlowaNET.Dictionaries
{
    using System.Collections.Generic;

    using Currencies;

    public class PolishWithsStemsDictionary : IDictionaries
    {
        public PolishWithsStemsDictionary()
        {
            Unity = new List<string>
                {
                    "","jeden","dwa" , "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć","zero"
                };

            OthersTens = new List<string>
                {
                    "","jedenaście", "dwanaście","trzynaście" , "czternaście", "piętnaście", "szesnaście", "siedemnaście", "osiemnaście", "dziewiętnaście"
                };

            Tens = new List<string>
                {
                    "","dziesięć", "dwadzieścia","trzydzieści" , "czterdzieści", "pięćdziesiąt", "sześćdziesiąt", "siedemdziesiąt", "osiemdziesiąt", "dziewięćdziesiąt"
                };

            Hundreds = new List<string>
                {
                    "","sto", "dwieście","trzysta" , "czterysta", "pięćset", "sześćset", "siedemset", "osiemset", "dziewięćset"
                };

            Endings = new string[,]
            {
                 {"","",""},
                {"tysiąc","tysiące","tysięcy"},
                {"milion","miliony","milionów"},
                {"miliard","miliardy","miliardów"},
                {"bilion","biliony","bilionów"},
                {"biliard","biliardy","biliardów"}
            };

            Sign = new List<string>
            {
                "plus", "minus"
            };

            Current = new string[,]
            {
                {"","",""},
                {"złoty","złote","złotych"},
                {"grosz","grosze","groszy"}
            };
           
        }

        public List<string> Unity { get; }

        public List<string> OthersTens { get; }

        public List<string> Tens { get; }

        public List<string> Hundreds { get; }

        public string[,] Endings { get; }

        public List<string> Sign { get; }

        public string[,] Current { get; }

        public bool HasStems { get; } = true;
    }
}