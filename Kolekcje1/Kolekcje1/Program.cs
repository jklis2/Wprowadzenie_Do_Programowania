using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> zwierzaki = new List<string>();
            zwierzaki.Add("pies");
            zwierzaki.Add("ryba");
            zwierzaki.Add("małpa");
            zwierzaki.Add("ptak");
            if(zwierzaki.Contains("krowa"))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            zwierzaki.Reverse();
            zwierzaki.Sort();
            Console.WriteLine(string.Join(", ", zwierzaki));
        }
    }
}
