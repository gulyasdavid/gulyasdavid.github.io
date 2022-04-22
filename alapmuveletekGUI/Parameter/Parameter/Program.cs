using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Udvozlet(); //Nézzük meg, hogy mi lesz a kimenet ez
            Udvozlet("Hello"); // és ez esetén.
            Console.ReadLine();
        }
        static void Udvozlet(string s = "Üdvözöllek a programban!")
        {
            Console.WriteLine(s);
        }
    }
}
