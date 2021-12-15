using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolka_1
{
    class aplikacja_menu
    {
        static List<firma> ListaFirm = new List<firma>();
        public static void Menu()
        {
            Console.Clear();
            string ramka="";
            for (int i = 0; i < 80; i++)
            {
                ramka += "=";
                
            }
            Console.WriteLine("\n\n\n\n\n");
            centrujText(ramka);
            centrujText(" ");

            centrujText("MENU APLIKACJI BIUROWEJ!");
            centrujText("F - ZAŁÓŻ FIRMĘ ");
            centrujText("K - DODAJ KATALOGI ");
            centrujText("W - WYJŚCIE ");
            centrujText(" ");
            centrujText(ramka);

            ReakcjaNaKlawisze();
            Console.ReadLine();

        }
        static void centrujText(string Tekst)
        {
            Console.Write(new string(' ', (Console.WindowWidth - Tekst.Length) / 2));
            Console.WriteLine(Tekst);

        }

        static void ReakcjaNaKlawisze()
        {
            ConsoleKeyInfo ckey = Console.ReadKey();
            switch (ckey.Key)       
            {
                case ConsoleKey.F:
                    MenuFirma();
                    break;
                case ConsoleKey.K:
                    MenuKatalogi();
                    break;
                case ConsoleKey.X:
                    break;

                default:
                    break;
            }
        }

        public static void MenuFirma()
        {
            Console.Clear(); 
            string ramka = "";
            for (int i = 0; i < 80; i++)
            {
                ramka += "=";

            }
            Console.WriteLine("\n\n\n\n\n");
            centrujText(ramka);
            centrujText(" ");

            centrujText("DODAWANIE FIRMY");
            centrujText(" ");
            centrujText(ramka);

            firma firmaDoDodania = new firma();
            centrujText("Podaj nazwę firmy:");
            firmaDoDodania.NazwaFirmy = Console.ReadLine();

            centrujText("Podaj adres firmy:");
            firmaDoDodania.Adres = Console.ReadLine();

            centrujText("Podaj kod pocztowy firmy:");
            firmaDoDodania.KodPocztowy = Console.ReadLine();

            centrujText("Podaj telefon firmy:");
            firmaDoDodania.Telefon = Console.ReadLine();

            ListaFirm.Add(firmaDoDodania);

            var firma=Console.ReadLine();
            Menu();
            ReakcjaNaKlawisze();
            Console.ReadLine();

        }

        public static void MenuKatalogi()
        {
            Console.Clear();
            string ramka = "";
            for (int i = 0; i < 80; i++)
            {
                ramka += "=";

            }
            Console.WriteLine("\n\n\n\n\n");
            centrujText(ramka);
            centrujText(" ");

            centrujText("WYBIERZ FIRMĘ DO STWORZEINA KATALOGÓW!");
            centrujText(" ");
            centrujText(ramka);
            Menu();
            ReakcjaNaKlawisze();
            Console.ReadLine();

        }
    }

    class firma
    {
        public string NazwaFirmy { get; set; }
        public string Adres { get; set; }
        public string KodPocztowy { get; set; }
        public string Telefon { get; set; }
    }
}
