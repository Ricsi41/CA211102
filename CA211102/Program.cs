using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA211102
{
    class Program
    {
        static List<Ember> emberek = new List<Ember>();
        static void Main(string[] args)
        {
            InitEmberek();

            //összegzés
            float res_01 = emberek.Sum(x => x.Suly);

            //átlag
            double res_02 = emberek.Average(x => x.Magassag);

            //megszámlálás
            int res_03 = emberek.Count(x => x.Iskola == "Verebély");

            //legkisebb magasság
            int res_04 = emberek.Min(x => x.Magassag);

            //legnagyobb súly
            float res_05 = emberek.Max(x => x.Suly);

            //Első/Utolsó <T>-nek megfelelő elem
            //pl:első Szondy
            var res_06 = emberek.First(x => x.Iskola == "Szondy");
            //pl: utolsó 180cm-nél alacsonyabb
            var res_07 = emberek.Last(x => x.Magassag < 180);

            //összes verebélyes
            IEnumerable<Ember> res_08 = emberek.Where(x => x.Iskola == "Verebély");
            List<Ember> res_09 = res_08.ToList();

            //"csak" adott tuldaonságok listája
            IEnumerable<string> res_10 = emberek.Select(x => x.Nev);
            List<string> res_11 = res_10.ToList();

            //Rendezés
            //születési dátum szerint növekvőbe
            IOrderedEnumerable<Ember> res_12 = emberek.OrderBy(x => x.Szul);
            //súly szerint csökkenőbe
            IOrderedEnumerable<Ember> res_13 = emberek.OrderByDescending(x => x.Szul);

            //Tartalmaz-e?
            bool res_14 = emberek.Any(x => x.Nev == "Szabolcsi Spániel");

            //csoportosítás
            IGrouping<string, Ember> res_15 = (IGrouping<string, Ember>)emberek.GroupBy(x => x.Iskola);
            


            Console.ReadKey();
        }

        private static void InitEmberek()
        {
            emberek.Add(new Ember()
                {
                    Nev = "Akciós Áron",
                    Szul  = new DateTime(2001,03,21),
                    Iskola = "Verebély",
                    Magassag = 180,
                    Suly = 72.6F,
                });
            emberek.Add(new Ember()
            {
                Nev = "Szabolcsi Spániel",
                Szul = new DateTime(2005, 10, 29),
                Iskola = "Veres",
                Magassag = 162,
                Suly = 58.9F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Szalai Anna",
                Szul = new DateTime(2001, 09, 24),
                Iskola = "Verebély",
                Magassag = 188,
                Suly = 79.9F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kelentai Izsák",
                Szul = new DateTime(2004, 04, 17),
                Iskola = "Szondy",
                Magassag = 168,
                Suly = 67.7F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Zloch Anasztázia",
                Szul = new DateTime(2005, 05, 30),
                Iskola = "Bródy",
                Magassag = 174,
                Suly = 68.3F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Nagy Béla",
                Szul = new DateTime(2007, 12, 30),
                Iskola = "Teleki",
                Magassag = 175,
                Suly = 59.7F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Pelyvás Helga",
                Szul = new DateTime(2002, 07, 12),
                Iskola = "Eötvös",
                Magassag = 169,
                Suly = 63.7F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kejtor Kornél",
                Szul = new DateTime(2005, 11, 01),
                Iskola = "Neimann",
                Magassag = 172,
                Suly = 74.9F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kovács Kevin",
                Szul = new DateTime(1999, 08, 10),
                Iskola = "Obudai",
                Magassag = 192,
                Suly = 90.3F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Bartos Márk",
                Szul = new DateTime(2004, 07 , 02),
                Iskola = "Bolyai",
                Magassag = 167,
                Suly = 51.6F,
            });
        }
    }
}
