using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia_spoj
{
    class Program
    {
        private static string[] GetInput()
        {
            string input = Console.ReadLine();
            //Console.WriteLine(input);
            return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
        static void Main(string[] args)
        {
            string[] inputSplit = GetInput();
            if (inputSplit[0] == "A" && inputSplit.Length == 3)
            {
                PrintVariantA(inputSplit);
            }
            else if (inputSplit[0] == "B" && inputSplit.Length == 2)
            {
                PrintVariantB(inputSplit);
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private static void PrintVariantA(string[] inputSplit)
        {
            //Console.WriteLine("robimy A");
            int n = Int32.Parse(inputSplit[1]);
            int m = Int32.Parse(inputSplit[2]);
            if (n % 2 == 0)
            {
                ++n;
            }
            if (m % 2 == 0)
            {
                ++m;
            }
            //Console.WriteLine(n);
            //Console.WriteLine(m);
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == 0 || j == 0 || i == m - 1 || j == n - 1 || i == (m - 1) / 2 || j == (n - 1) / 2)
                        Console.Write("*");
                    else
                        Console.Write(".");

                }
                Console.WriteLine();
            }
        }

        private static void PrintVariantB(string[] inputSplit)
        {
            int n = Int32.Parse(inputSplit[1]);
            //Console.WriteLine("robimy B");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == 0 || i == n - 1 || i == j)
                        Console.Write("*");
                    else
                        Console.Write(".");

                }
                Console.WriteLine();
            }
        }
    }
}