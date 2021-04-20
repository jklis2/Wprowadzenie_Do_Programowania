using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMPSEQ7
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string S = Console.ReadLine();
            int a = int.Parse(n);
            string[] SSplit = S.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] Dane = Array.ConvertAll<string, int>(SSplit, int.Parse);
            int b = 0;
            int zmiana = 0;
            for (int i = 0; i < a - 1; i++)
            {
                if (Dane[i] > Dane[i+1])
                {
                    b++;
                }
                else if (b == 0)
                {
                    break;
                }
                else
                {
                    b++;
                    zmiana++;
                    break;
                }
            }
            for (int k = 0 + b; k < a - 1; k++) 
            {
                if (Dane[k] < Dane[k + 1])
                {
                    b++;
                }
                else
                {
                    b++;
                    break;
                }
            }
            if (b == a-1 && zmiana == 1)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
        }
    }
}
