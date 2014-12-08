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

            jednosi = new List<string>
                {
                    "zero", "jeden","dwa" , "trzy", "cztery", "piec", "szesc", "siedem", "osiem", "dziewiec"
                };

            nastki = new List<string>
                {
                    "jedenascie", "dwanascie","trzynascie" , "czternascie", "pietnascie", "szesnascie", "siedemnascie", "osiemnascie", "dziewietnascie"
                };

            dziesiatki = new List<string>
                {
                    "dziesiec", "dwadziescia","trzydziesci" , "czterdziesci", "piecdziesiat", "szescdziesiat", "siedemdziesiat", "osiemdziesiat", "dziewiecdziesiat"
                };

            setki = new List<string>
                {
                    "sto", "dwiescie","trzysta" , "czterysta", "piecset", "szescset", "siedemset", "osiemset", "dziewiecset"
                };

            koncowki = new string[,] 
            {
                {"tysiac","tysiace","tysiecy"},
                {"milion","miliony","milionow"},
                {"miliard","miliardy","miliardow"},
                {"bilion","biliony","bilionow"},
                {"biliard","biliardy","biliardow"}
            };




        }

        private static string[,] koncowki;

        private static List<String> jednosi;

        private static List<String> nastki;

        private static List<String> dziesiatki;

        private static List<String> setki;


        public static List<String> Jednosci
        {
            get
            {
                return jednosi;
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





    }
}
