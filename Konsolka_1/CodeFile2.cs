using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Konsolka_1
{
    class Program2
    {
        static int moja_w = 98;
        public static void moj_switch()
        {
            switch (moja_w)
            {
                case 0:
                    dla_zera();
                    break;
                case 1:
                    dla_jedynki();
                    break;
                case 2:
                    dla_dwojki();
                    break;
                default:
                    cokolwiek();
                    break;
            }
        }
        static void dla_zera()
        {
            Console.WriteLine("jest zero");
        }
        static void dla_jedynki()
        {
            Console.WriteLine("jest jeden");
        }
        static void dla_dwojki()
        {
            Console.WriteLine("jest dwa");
        }
        static void cokolwiek()
        {
            Console.WriteLine("cokolwiek");

        }

        public static void test()
        {
            ArrayList abc = new ArrayList();
            abc.Add("słowo");
            abc.Add(true);
            abc.Add(324);
            abc.Add("słowo2");

            foreach (var item in abc)
            {


                switch (item.GetType().Name)
                {
                    case "Int32":
                        Console.WriteLine("To jest int");
                        break;
                    case "String":
                        Console.WriteLine("To jest string");
                        break;
                    case "Boolean":
                        Console.WriteLine("To jest boolean");
                        break;
                    default:
                        Console.WriteLine("To jest obiekt");
                        break;
                }
            }
        }
    }

}