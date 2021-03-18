using System;

namespace Spoj3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            while (true)
            {
                string napis = Console.ReadLine();
                if (string.IsNullOrEmpty(napis)) ;
                {
                    break;
                }

                int liczba = int.Parse(napis);
                suma += liczba;
                Console.WriteLine(suma);

            }
        }
    }
}
