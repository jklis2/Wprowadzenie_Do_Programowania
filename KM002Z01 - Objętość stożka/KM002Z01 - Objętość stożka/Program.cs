using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM002Z01___Objętość_stożka
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long R = long.Parse(input[0]);
            long L = long.Parse(input[1]);
            decimal V = 0;

            if (R < 0 || L < 0)
            {
                Console.WriteLine("Ujemny argument");
                return;
            }
            try
            {
                V = obj(R, L);
                Console.WriteLine($"{Math.Floor(V)} {Math.Ceiling(V)}");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Obiekt nie istnieje");
            }
        }
        static decimal obj(long R, long L)
        {
            double H = Math.Sqrt(-(R * R) + (L * L));
            if (double.IsNaN(H))
            {
                throw new ArithmeticException();
            }
            return ((decimal)Math.PI * R * R * (decimal)H) / 3;
        }
    }
}
