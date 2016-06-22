
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    internal class PolishDictionary : IDictionaries
    {
        public PolishDictionary()
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

            current = new string[,] 
            {
                {"","",""},
                {"zloty","zlote","zlotych"},
                {"grosz","grosze","groszy"}
            };
        }

        private  string[,] endings;

        private  List<String> unity;

        private  List<String> othersTens;

        private  List<String> tens;

        private  List<String> hundreds ;

        private  List<String> sign;

        private  string[,] current;


        public  List<String> Unity
        {
            get
            {
                return unity;
            }
        }

        public  List<String> OthersTens
        {
            get
            {
                return othersTens;
            }
        }

        public  List<String> Tens
        {
            get
            {
                return tens;
            }
        }

        public  List<String> Hundreds
        {
            get
            {
                return hundreds;
            }
        }

        public  string[,] Endings
        {
            get
            {
                return endings;
            }
        }

        public  List<String> Sign
        {
            get
            {
                return sign;
            }
        }

        public  string[,] Current
        {
            get
            {
                return current;
            }
        }
    }
}
