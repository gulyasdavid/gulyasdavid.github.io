using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rand_Tomb_Ossz_Fugg
{
    internal class Program
    {
        static Random r = new Random();
        static int[] RandTomb(int Tmeret, int mettol, int meddig)
        {
            int[] visszaT = new int[Tmeret];
            for (int i = 0; i < visszaT.Length; i++)
            {
                visszaT[i] = r.Next(mettol, meddig);
            }
            Osszegzo(visszaT); //Függvényen belül is meg lehet hívni másik függvényt
            return visszaT;
        }
        //Készítsünk olyan függvényt, ami összegzi az előző tömb tartalmát. (Ezt a függvényt az előzőből hívjuk meg.)
        static int Osszegzo(int[] visszaT)
        {
            int ossz = 0;
            for (int i = 0; i < visszaT.Length; i++)
            {
                ossz = ossz + visszaT[i];
            }
            Console.WriteLine("A tömbbe legenerált számok összege: " + ossz);
            return ossz;
        }
        /*
        Csináljunk egy függvényt, ami visszaad egy int tömböt a megadott értékeken belül, randomolt számokkal. A tömb méretét is paraméterként kezeljük.
         */
        static void Main(string[] args)
        {
            int tombmeret = EBF("Add meg a tömb méretét! Az elemszám 0-nál nagyobb és 10.001-nél kisebb egész szám lehet!",0,10000);
            int minertek = EBF("Add meg, mekkora lehet a legkisebb érték a tömbben! Az INT típus legkisebb értéke a minimum!");
            int maxertek = EBF("Add meg, mekkora lehet a legnagyibb érték a tömbben! Az INT típus legnagyobb értéke a maximum!");
            RandTomb(tombmeret, minertek, maxertek);
            Console.WriteLine("Nyomd meg az Entert a befejezéshez!");
            Console.ReadLine();
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
