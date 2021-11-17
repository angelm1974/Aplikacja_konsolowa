using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Konsolka_1
{
    class Program1
    {
        static int temp_wody = 0;
        static bool jest_sol = false;
        static int czas_gotowania = 0;
        static void zagrzej_wode()
        {
 //           if (temp_wody < 100) {
                temp_wody += 1;
//            };
            Console.WriteLine("Woda ma temperaturę {0}", temp_wody);
        }
    
        static void dodaj_sol(bool czy_dodano) {
            if (czy_dodano == true)
            {
                Console.WriteLine("Sól dodana. Nie sypiemy więcej");
            }
            else
            {
                Console.WriteLine("Dodaję sól");
                jest_sol = true;
            }
        }
        private static void wrzuc_jajko()
        {
            Console.WriteLine("Wrzuciłem jajko!!!");
        }

        static public void gotowanie_jajka()
        {

            
            if (temp_wody >= 100)
            {
                wrzuc_jajko();
                czas_gotowania += 1;
                
                if (czas_gotowania >= 5)
                {
                    Console.WriteLine("Ugotowane jajko!!!");
                }
                else
                {
                    
                    gotowanie_jajka();
                }
            
            }
            else
            {
                dodaj_sol(jest_sol);
                zagrzej_wode();
                gotowanie_jajka();

            }


        }


    }
}