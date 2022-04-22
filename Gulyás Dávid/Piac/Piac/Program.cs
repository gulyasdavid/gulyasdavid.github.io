using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Piac
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. feladat
            string[] szoveg = File.ReadAllLines("be.csv");
            Console.WriteLine("4. feladat: Kiiratom a fájlnak a tartalmát:");
            foreach (string sor in szoveg)
            {
                Console.WriteLine("\t" + sor);
            }
            string[] alma = szoveg[0].Split(';');
            string[] krumpli = szoveg[1].Split(';');
            string[] narancs = szoveg[2].Split(';');
            string[] banan = szoveg[3].Split(';');
            string[] paradicsom = szoveg[4].Split(';');
            string[] paprika = szoveg[5].Split(';');
            Console.WriteLine("5. feladat: Ennyi zöldségnek volt az ára 500 forint alatt: ");
            Console.WriteLine("Alma: "+alma[1]);
            Console.WriteLine("Krumpli: "+krumpli[1]);
            Console.WriteLine("Narancs: "+narancs[1]);
            Console.WriteLine("Banán: "+banan[1]);
            Console.WriteLine("Paprika: "+paprika[1]);
            Console.WriteLine("Ezekből a zöldségből és gyümölcsből vettem több, mint egy kilót: "+alma[0]+", "+krumpli[0]+", "+narancs[0]+" és "+paradicsom[0]+".");
            int adb = int.Parse(alma[2]);
            int kdb = int.Parse(krumpli[2]);
            int ndb = int.Parse(narancs[2]);
            int bdb = int.Parse(banan[2]);
            int prdb = int.Parse(paradicsom[2]);
            int ppdb = int.Parse(paprika[2]);
            int zkg = adb + kdb + bdb + ndb + prdb + ppdb;
            Console.WriteLine("7. feladat: Kiló zöldséget és gyümölcsöt kellett hazacipelnem: "+zkg);
            Console.WriteLine("Nyomj egy gombot a befejezéshez!");
            Console.ReadKey();
        }
    }
}
