using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET
{
    class LiczbyNaSlowa : LiczbyNaSlowaBuldier
    {
        private StringBuilder rezultat;

        // liczba setek
        private int setki;

        //liczba dziesiątek
        private int dziesiatki;

        //liczba jedności
        private int jednosci;

        //liczba nastek
        private int nastki;

        //rząd wielkości
        private int rzadWielkosci;

        //forma gramatyczna
        private int formaGramatyczna;
        
        public override string Build()
        {
            rezultat = new StringBuilder();

            if (this.Liczba == 0)
            {
                return rezultat.Append(Slowniki.Jednosci[10]).ToString();
            }

            if (this.Liczba < 0)
            {
                rezultat.Append(Slowniki.Znak[2]);
            }

            var liczbaTemp = this.Liczba;

            this.rzadWielkosci = 0;
            
            while (liczbaTemp != 0)
            {
                this.setki = (liczbaTemp % 1000) / 100;
                this.dziesiatki = (liczbaTemp % 100) / 10;
                this.jednosci = liczbaTemp % 10;

                if (this.dziesiatki == 1 && this.jednosci > 0)
                {
                    this.nastki = this.jednosci;
                    this.dziesiatki = 0;
                    this.jednosci = 0;
                }
                else
                {
                    this.nastki = 0;
                }

                var drugaForma = new int[] { 2, 3, 4 };


                if (this.jednosci == 1 && (this.setki + this.dziesiatki + this.nastki == 0))
                {
                    this.formaGramatyczna = 0;
                }
                else if (drugaForma.Contains(this.jednosci))
                {
                    this.formaGramatyczna = 1;
                }
                else
                {
                    this.formaGramatyczna = 2;
                }

                if ((this.setki + this.jednosci + this.nastki + this.dziesiatki) > 0)
                {
                    var temp = rezultat.ToString().Trim();

                    rezultat.AppendFormat("{0}{1}{2}{3}{4}{5}",
                        this.DajOdstep(Slowniki.Setki[this.setki]),
                        this.DajOdstep(Slowniki.Dziesiatki[this.dziesiatki]),
                        this.DajOdstep(Slowniki.Nastki[this.nastki]),
                        this.DajOdstep(Slowniki.Jednosci[this.jednosci]),
                        this.DajOdstep(Slowniki.Koncowki[this.rzadWielkosci, this.formaGramatyczna]),
                        temp);
                }
              
                this.rzadWielkosci += 1;

                liczbaTemp = liczbaTemp / 1000;
            }

            return rezultat.ToString().Trim();
            
        }

        private string DajOdstep(string ciag)
        {
            return String.IsNullOrEmpty(ciag) ? string.Empty : " " + ciag;
        }
    }
}
