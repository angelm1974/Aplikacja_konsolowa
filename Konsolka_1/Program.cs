using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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
            //typ_referencyjny();
            // zmienne_lancuchowe();
            typ_wskaznikowy();
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

        static void zmienne_lancuchowe()
        {
            string sciezka1 = @"C:\Users\mariu\Source\Repos\aplikacja_konsolowa2\";
            sciezka1 += "folder5";
            Directory.CreateDirectory(sciezka1);
        }    
  unsafe
        static void typ_wskaznikowy()
        {
            
            int x = 200;
            int* ptr;
            ptr = &x;

            Console.WriteLine((int)ptr);
            Console.WriteLine(*ptr);
        }
    }
}
