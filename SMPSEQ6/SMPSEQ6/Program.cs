using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMPSEQ6
{
    class Program
    {
        static void Main(string[] args)
        {
            string Dane = Console.ReadLine();
            string S = Console.ReadLine();
            string Q = Console.ReadLine();
            string[] DaneSplit = Dane.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] SSplit = S.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] QSplit = Q.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = Int32.Parse(DaneSplit[0]);
            int x = Int32.Parse(DaneSplit[1]);
            if (x>=0)
            {
                for (int i = 0; i<n; ++i)
                {
                    for (int y = -x; y <= x; ++y)
                    {
                        if (i+y<n && i+y>=0 && SSplit[i] == QSplit[i + y])
                        {
                            Console.Write($"{i + 1}" + " ");
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.Write("X ujemny, blad");
            }
        }
    }
}
