using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public string plec;

        public int ObliczWiek()
        {
            return (DateTime.Now.Year - rokUrodzenia);
        }
        public void DodajPrzedrostek()
        {
            if (plec == "m")
                Console.WriteLine("{0} {1} jest mezczyzna", imie, nazwisko);
            else if (plec == "k")
                Console.WriteLine("{0} {1} jest kobieta", imie, nazwisko);
        }
    }
}
