using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cim_Refer_Szer_Ert_Atad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Cím (referencia) szerinti paraméterátadás: A "ref" kulcsszóval
            érhető el a cím szerinti paraméterátadás. A "ref" kulcsszót az
            aktuális és a formális paraméter előtt is kell használni!
            Ebben az esetben az átadott aktuális paraméterre, változóra egy
            hivatkozás jön létre a memória tartományára. Csak a memóriaterület
            címe/azonosítója adódik át, így az alprogramon belül végzett
            változtatások érvénybe lépnek az adott változóban is.
            Fontos! Az összetett adatszerkezetek, tömbök, listák, objektumok, ...
            Minden esetben referencia, tehát cím szerint adódnak át.
            */
            int a = 6, b = 4, c;
            c = KetszeresetOsszeadoFuggveny(ref a, ref b);
            Console.WriteLine("\a'\' értéke:{0}\n\'b\' értéke:{1}\n\'c\' értéke:{2}", a, b, c);
            Console.ReadLine();
        }
        static int KetszeresetOsszeadoFuggveny(int szam1, int szam2)
        {
            szam1 = szam1 * 2;
            szam2 = szam2 * 2;
            return szam1 + szam2;
        }
    }
}
