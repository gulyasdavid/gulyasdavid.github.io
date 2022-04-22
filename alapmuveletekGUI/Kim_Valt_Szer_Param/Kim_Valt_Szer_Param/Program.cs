using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kim_Valt_Szer_Param
{
    class Program
    {
        /*
         Kimeneti változó szerinti paraméterátadás: Az 'out' kulcsszóval érhető el ez az átadási mód. Szintén meghíváskor és az alprogram dekralásakor
         is meg kell adni! hasonlít a cím szerinti átadásra, viszont az átadott paraméternek kezdetben nincs értéke. A függvényünk hivatott ennek
        értéket adni, de kötelező az értékadás!
         */
        static void Main(string[] args)
        {
            bool paros;
            Paros(9, out paros);
            Console.ReadLine();
        }
        static void Paros(int a, out bool log)
        {
            if (a % 2 == 0)
            {
                log = true;
            }
            else
            {

            }
        }
    }
}
