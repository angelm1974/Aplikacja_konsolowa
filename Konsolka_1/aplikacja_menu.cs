using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolka_1
{
    class aplikacja_menu
    {
        static List<firma> ListaFirm = new List<firma>();
        static string sciezka = @"D:\Firmy";
        public static void Menu()
        {
            Console.Clear();
            string ramka = mojaRamka();
            Console.WriteLine("\n\n\n\n\n");
            RamkaGora(ramka);
            centrujText("MENU APLIKACJI BIUROWEJ!");
            centrujText("F - ZAŁÓŻ FIRMĘ ");
            centrujText("K - DODAJ KATALOGI ");
            centrujText("W - WYJŚCIE ");
            RamkaDol(ramka);

            ReakcjaNaKlawisze();
            Console.ReadLine();
        }

        private static void RamkaDol(string ramka)
        {
            centrujText(" ");
            centrujText(ramka);
        }

        private static void RamkaGora(string ramka)
        {
            centrujText(ramka);
            centrujText(" ");
        }

        private static string mojaRamka()
        {
            string ramka = "";
            for (int i = 0; i < 80; i++)
            {
                ramka += "=";
            }

            return ramka;
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
            string ramka = mojaRamka();
            Console.WriteLine("\n\n\n\n\n");
            RamkaGora(ramka);
            centrujText("DODAWANIE FIRMY");
            RamkaDol(ramka);

            firma firmaDoDodania = new firma();

            firmaDoDodania.NazwaFirmy = Wyswietl_i_Pobierz("Podaj nazwę firmy:");
            firmaDoDodania.Adres = Wyswietl_i_Pobierz("Podaj adres firmy:");
            firmaDoDodania.KodPocztowy = Wyswietl_i_Pobierz("Podaj kod pocztowy firmy:");
            firmaDoDodania.Telefon = Wyswietl_i_Pobierz("Podaj telefon firmy:");
            ListaFirm.Add(firmaDoDodania);

            powrotDoMenu();

            string Wyswietl_i_Pobierz(string tekst)
            {
                centrujText(tekst); // "Podaj nazwę firmy:");
                return Console.ReadLine();
            }
        }

        private static void powrotDoMenu()
        {
            Menu();
            ReakcjaNaKlawisze();
        }

        public static void MenuKatalogi()
        {
            Console.Clear();


            Console.Clear();
            string ramka = mojaRamka();
            Console.WriteLine("\n\n\n\n\n");
            RamkaGora(ramka);
            centrujText("WYBIERZ FIRMĘ DO STWORZEINA KATALOGÓW!");
            RamkaDol(ramka);
            int numer = 0;
            foreach (var item in ListaFirm)
            {
                Console.WriteLine($"{numer} - {item.NazwaFirmy}");
                numer++;
            }
            centrujText(ramka);
            centrujText(" ");

            centrujText("WYBIERZ NUMER");
            numer = int.Parse(Console.ReadLine());
            var mojafirma = ListaFirm[numer].NazwaFirmy;
            string sciezkaFirmy = $"{sciezka}\\{mojafirma}";
            Directory.CreateDirectory(sciezkaFirmy);
            Directory.CreateDirectory(sciezkaFirmy + "\\KOSZTY");
            Directory.CreateDirectory(sciezkaFirmy + "\\FAKTURY");
            Directory.CreateDirectory(sciezkaFirmy + "\\RACHUNKI");
            Directory.CreateDirectory(sciezkaFirmy + "\\INNE");
            centrujText(ramka);
            centrujText(" ");
            centrujText("ZROIBONO");
            Console.ReadLine();
            Menu();
            ReakcjaNaKlawisze();

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
