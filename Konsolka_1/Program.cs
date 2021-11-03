using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Konsolka_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kod wyświetlający napis hello world
            //oraz trzymający konsolę otwartą

            Console.WriteLine("Hello World!");
            //zmienne_przyklad1();
            typ_referencyjny();
            Console.ReadKey();
        }

        /// <summary>
        /// Sprawdzenie ile pamięci zajmuje dana zmienna
        /// i wyświetlenie w konsoli
        /// </summary>
        static void zmienne_przyklad1()
        {
            Console.WriteLine("Moja zmienna typu int zajmuje: {0}", sizeof(char));
        }

        static void typ_referencyjny()
        {
            int olek = 1500;

            object o = olek;
            olek = 12;
            int liczba = (int)o;
            Console.WriteLine("moja liczba to: " + liczba.ToString());
        }

    }
}
