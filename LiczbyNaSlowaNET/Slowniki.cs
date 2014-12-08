
// Copyright (c) 2014 Przemek Walkowski

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    static class Slowniki
    {
        static Slowniki()
        {

            jednosci = new List<string>
                {
                    "","jeden","dwa" , "trzy", "cztery", "piec", "szesc", "siedem", "osiem", "dziewiec","zero"
                };

            nastki = new List<string>
                {
                    "","jedenascie", "dwanascie","trzynascie" , "czternascie", "pietnascie", "szesnascie", "siedemnascie", "osiemnascie", "dziewietnascie"
                };

            dziesiatki = new List<string>
                {
                    "","dziesiec", "dwadziescia","trzydziesci" , "czterdziesci", "piecdziesiat", "szescdziesiat", "siedemdziesiat", "osiemdziesiat", "dziewiecdziesiat"
                };

            setki = new List<string>
                {
                    "","sto", "dwiescie","trzysta" , "czterysta", "piecset", "szescset", "siedemset", "osiemset", "dziewiecset"
                };

            koncowki = new string[,] 
            {
                {"","",""},
                {"tysiac","tysiace","tysiecy"},
                {"milion","miliony","milionow"},
                {"miliard","miliardy","miliardow"},
                {"bilion","biliony","bilionow"},
                {"biliard","biliardy","biliardow"}
            };

            znak = new List<string>
            {
                "plus", "minus"
            };



        }

        private static string[,] koncowki;

        private static List<String> jednosci;

        private static List<String> nastki;

        private static List<String> dziesiatki;

        private static List<String> setki;

        private static List<String> znak;


        public static List<String> Jednosci
        {
            get
            {
                return jednosci;
            }
        }
        
        public static List<String> Nastki
        {
            get
            {
                return nastki;
            }
        }

        public static List<String> Dziesiatki
        {
            get
            {
                return dziesiatki;
            }
        }

        public static List<String> Setki
        {
            get
            {
                return setki;
            }
        }

        public static string[,] Koncowki
        {
            get
            {
                return koncowki;
            }
        }

        public static List<String> Znak
        {
            get
            {
                return znak;
            }
        }






    }
}
