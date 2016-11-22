using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Champions;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
            test2();
            //test3();
            test4();
        }

        static void test()
        {
            ChampionListe c = new ChampionListe();
            c.Chargement();
            Console.WriteLine(c);
            Console.ReadKey();
        }

        static void test2()
        {
            ObjetListe c = new ObjetListe();
            c.Chargement();
            Console.WriteLine(c);
            Console.ReadKey();
        }

        static void test3()
        {
            String msg = Console.ReadLine(); ;
            int nb = 10;
            Console.WriteLine(msg, nb);
            Console.ReadKey();
        }
        static void test4()
        {
            BuildListe b = new BuildListe();
            Build b1 = new Build();
            b.Chargement();
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
