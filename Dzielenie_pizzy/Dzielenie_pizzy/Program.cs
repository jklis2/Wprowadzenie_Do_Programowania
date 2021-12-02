using System;
using System.Diagnostics;
using System.Text;

namespace Dzielenie_pizzy
{
    class Program
    {
        public static long IleKawalkow(int n)
        {
            Debug.Assert(n >= 1);
            if (n == 1) 
                return 2;
            else 
                return IleKawalkow(n - 1) + n;
        }

        public static long IleKawalkowIter(int n)
        {
            Debug.Assert(n >= 1);
            if (n == 1) 
                return 2;

            long poprzednia, aktualna;
            poprzednia = aktualna = 2;
            for (int i = 2; i <= n; i++)
            {
                aktualna = poprzednia + i;
                poprzednia = aktualna;
            }
            return aktualna;
        }

        public static long IleKawalkowFinal(long n)
        {
            Debug.Assert(n >= 1);
            if (n == 1) 
                return 2;

            return (n * n + n + 2) / 2;
        }

        static void Main(string[] args)
        {
            var result = new StringBuilder();
            int T = int.Parse(Console.ReadLine());
            for (int i = 1; i <= T; i++)
            {
                long n = long.Parse(Console.ReadLine());
                result.AppendLine(IleKawalkowFinal(n).ToString());
            }
            Console.WriteLine(result.ToString());
        }
    }
}