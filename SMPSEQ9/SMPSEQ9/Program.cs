using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMPSEQ9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] tablica1 = Console.ReadLine().Split(' ').Take(n).Select(int.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            int[] tablica2 = Console.ReadLine().Split(' ').Take(m).Select(int.Parse).ToArray();
            int dzielenie1 = tablica1.Sum() / n;
            int dzielenie2 = tablica2.Sum() / m;
            if (tablica1.Length >= 2 && tablica1.Length <= 100 && tablica1.Length >= -100 && tablica2.Length >= 2 && tablica2.Length <= 100 && tablica2.Length >= -100)
            {
                if (tablica1.Sum() / n == 0)
                {
                    Console.WriteLine(string.Join(' ', tablica1));
                    return;
                }
                if (tablica2.Sum() / m == 0)
                {
                    Console.WriteLine(string.Join(' ', tablica2));
                    return;
                }
                if (dzielenie1 > dzielenie2)
                {
                    Console.WriteLine(string.Join(' ', tablica1));
                }
                else
                {
                    Console.WriteLine(string.Join(' ', tablica2));
                }

            }
        }
    }
}
