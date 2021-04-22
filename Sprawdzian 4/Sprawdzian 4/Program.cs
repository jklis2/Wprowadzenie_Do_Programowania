using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab = new int[3][]
            {
                  new int[] {-1},
                  new int[] {1},
                  new int[] {1}
            };
            double result = Srednia(tab);
            Console.WriteLine(result);
        }
        public static double Srednia(int[][] tab)
        {
            double suma = 0f;
            double wynik = 0f;
            int counter = 0;
            if (tab == null)
            {
                wynik = 0.00f;
                return wynik;
            }
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] != null)
                {
                    for (int j = 0; j < tab[i].Length; j++)
                    {
                        if (tab[i][j] > 0)
                        {
                            suma += tab[i][j];
                            counter++;
                        }
                    }
                }
            }
            if (counter == 0)
            {
                wynik = 0.00f;
                return wynik;
            }
            else
            {
                wynik = Math.Round(suma / counter, 2);
                return wynik;
            }
        }
    }
}
