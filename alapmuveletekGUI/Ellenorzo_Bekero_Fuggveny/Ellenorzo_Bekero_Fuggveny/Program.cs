using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellenorzo_Bekero_Fuggveny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EBF("Írj be egy számot 10 és 20 között! ", 10, 20);
            Console.ReadLine();
            /*
            Az alábbi programokban egy ellenőrzöttbekérés függvényt készítünk, aminek kötelezően meg kell adni egy üzenetet, valamint lehetősége
            adódik a függvény meghívójának arra, hogy megadja azt, hogy mely számok között fogadjon el értékeket a függvény. A függvény visszaadja
            a feltételnek megfelelő bekért számot.
             */
        }
        static int EBF(string bekerouzenet, int mettol = int.MinValue, int meddig = int.MaxValue)
        {
            int szam;
            do
            {
                Console.WriteLine(bekerouzenet);
            } while (!int.TryParse(Console.ReadLine(), out szam) || !(szam > mettol && szam < meddig));
            //Console.WriteLine(szam);
            return szam;
        }
    }
}
