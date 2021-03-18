using System;

namespace Suma
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Wprowadz Liczby:");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int Suma = A + B + C;
            Console.WriteLine($"Suma: {Suma}");

        }
    }
}
