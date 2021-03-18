using System;

namespace Spoj4
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string napis = Console.ReadLine();
                var tab = napis.Split(' ');
                int suma = 0;
                for (int j = 0; j < n; j++) ;
                {
                    int j = 0;
                    int x = int.Parse(tab[j]);
                    suma += x;
                }
                Console.WriteLine(suma);
            }

        }
    }
}
