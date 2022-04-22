using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ertek_Szer_Param_Atad
{
    internal class Program
    {
        /*
        Érték szerinti paraméterátadás: Ha nem adunk meg semmilyen kulcsszót, akkor ilyen módon adódnak át a változók. (Kivétel: tömbök, objektumok...)
        Ilyenkor az alprogram meghívásakor megadott aktuális paraméterek értéke átmásolódik az alprogram egy-egy megfelelő formális paraméterébe. Ezután
        a formális paramétert úgy használhatjuk, mintha egy változó lenne.
        */
        static void Main(string[] args)
        {
            int a = 6, b = 4, c;
            ////////////////////////////
            c = KetszeresetOsszeadoFuggveny(a, b);
            Console.WriteLine("\a'\' értéke:{0}\n\'b\' értéke:{1}\n\'c\' értéke:{2}", a, b, c);
            //a: 6, b: 4, c: 20
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
