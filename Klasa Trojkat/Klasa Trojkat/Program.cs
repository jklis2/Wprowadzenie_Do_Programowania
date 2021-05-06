using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_Trojkat
{
    class Program
    {
        static void Main(string[] args)
        {
            Klasa_Trojkat t;
            t = new Klasa_Trojkat(3, 4, 5);
            Console.WriteLine(t.ToString());
            Klasa_Trojkat domyslny = new Klasa_Trojkat();
            Console.WriteLine(domyslny);
        }
    }
}
