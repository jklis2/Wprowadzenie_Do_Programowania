using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMPSEQ5
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string S = Console.ReadLine();
            string m = Console.ReadLine();
            string q = Console.ReadLine();
            string[] SSplit = S.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] qSplit = q.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < SSplit.Length; ++i)
            {
                if (i < qSplit.Length && SSplit[i] == qSplit[i]) 
                    {
                    Console.Write($" {i + 1}" + " ");
                }
            }
        }
    }
}