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
            //  typ_wskaznikowy();
            //rzutowanie();
            definiowanie();
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
  //unsafe
  //      static void typ_wskaznikowy()
  //      {
            
  //          int x = 200;
  //          int* ptr;
  //          ptr = &x;

  //          Console.WriteLine((int)ptr);
  //          Console.WriteLine(*ptr);
  //      }

        static void rzutowanie()
        {
            int w1 = 0;
            int w2 = 14;
            double liczba = 3214112.324;
            w1 = w2;
            
            Console.WriteLine(12 + 32.5);
            w1 = (int)liczba;
            Console.WriteLine(Convert.ToSingle(w1));
        }

        static void definiowanie()
        {
            //int i, j, k;
            int i = 1, j = 2, k = 3;
            char c='c', ch='h';
            float f=23.423f, salary=234.4f;

            Console.WriteLine("i={0}, j={1}, k={2}",i,j,k);


        }

        static void wez_dane()
        {
            int liczba;
            liczba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("moja liczba to: {0}", liczba);
        }

    }
}
