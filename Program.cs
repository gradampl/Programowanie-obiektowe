using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Wojciech";
            dyrektor.nazwisko = "Jaśkiewicz";
            dyrektor.rokUrodzenia = 1950;
            dyrektor.plec = "m";

           // Console.WriteLine("{0} {1}, wiek lat {2}.",dyrektor.imie,dyrektor.nazwisko,dyrektor.ObliczWiek());
            dyrektor.DodajPrzedrostek();
            
            Console.ReadKey();
        }
    }
}
