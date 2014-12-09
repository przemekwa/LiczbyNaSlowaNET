
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    internal static class Dictionaries
    {
        static Dictionaries()
        {
            unity = new List<string>
                {
                    "","jeden","dwa" , "trzy", "cztery", "piec", "szesc", "siedem", "osiem", "dziewiec","zero"
                };

            othersTens = new List<string>
                {
                    "","jedenascie", "dwanascie","trzynascie" , "czternascie", "pietnascie", "szesnascie", "siedemnascie", "osiemnascie", "dziewietnascie"
                };

            tens = new List<string>
                {
                    "","dziesiec", "dwadziescia","trzydziesci" , "czterdziesci", "piecdziesiat", "szescdziesiat", "siedemdziesiat", "osiemdziesiat", "dziewiecdziesiat"
                };

            hundreds = new List<string>
                {
                    "","sto", "dwiescie","trzysta" , "czterysta", "piecset", "szescset", "siedemset", "osiemset", "dziewiecset"
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
        }

        private static string[,] endings;

        private static List<String> unity;

        private static List<String> othersTens;

        private static List<String> tens;

        private static List<String> hundreds ;

        private static List<String> sign;


        public static List<String> Unity
        {
            get
            {
                return unity;
            }
        }

        public static List<String> OthersTens
        {
            get
            {
                return othersTens;
            }
        }

        public static List<String> Tens
        {
            get
            {
                return tens;
            }
        }

        public static List<String> Hundreds
        {
            get
            {
                return hundreds;
            }
        }

        public static string[,] Endings
        {
            get
            {
                return endings;
            }
        }

        public static List<String> Sign
        {
            get
            {
                return sign;
            }
        }
    }
}
