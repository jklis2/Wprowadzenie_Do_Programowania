using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] zero = new char[,] { { ' ', '_', ' ' }, { '|', ' ', '|' }, { '|', '_', '|' } };

            char[,] jeden = new char[,] { { ' ', ' ', ' ' }, { ' ', ' ', '|' }, { ' ', ' ', '|' } };

            char[,] dwa = new char[,] { { ' ', '_', ' ' }, { ' ', '_', '|' }, { '|', '_', ' ' } };

            char[,] trzy = new char[,] { { ' ', '_', ' ' }, { ' ', '_', '|' }, { ' ', '_', '|' } };

            char[,] cztery = new char[,] { { ' ', ' ', ' ' }, { '|', '_', '|' }, { ' ', ' ', '|' } };

            char[,] pięć = new char[,] { { ' ', '_', ' ' }, { '|', '_', ' ' }, { ' ', '_', '|' } };

            char[,] sześć = new char[,] { { ' ', '_', ' ' }, { '|', '_', ' ' }, { '|', '_', '|' } };

            char[,] siedem = new char[,] { { ' ', '_', ' ' }, { ' ', ' ', '|' }, { ' ', ' ', '|' } };

            char[,] osiem = new char[,] { { ' ', '_', ' ' }, { '|', '_', '|' }, { '|', '_', '|' } };

            char[,] dziewięć = new char[,] { { ' ', '_', ' ' }, { '|', '_', '|' }, { ' ', ' ', '|' } };

            string liczba = Console.ReadLine();
            string[] cyfry = liczba.Split(' ');

            char[,] wynik = new char[3, cyfry[0].Length * 3];

            for (int i = 0; i < cyfry[0].Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (cyfry[0][i] == '0')
                        {
                            wynik[j, 3 * i + k] = zero[j, k];
                        }
                        else if (cyfry[0][i] == '1')
                        {
                            wynik[j, 3 * i + k] = jeden[j, k];
                        }
                        else if (cyfry[0][i] == '2')
                        {
                            wynik[j, 3 * i + k] = dwa[j, k];
                        }
                        else if (cyfry[0][i] == '3')
                        {
                            wynik[j, 3 * i + k] = trzy[j, k];
                        }
                        else if (cyfry[0][i] == '4')
                        {
                            wynik[j, 3 * i + k] = cztery[j, k];
                        }
                        else if (cyfry[0][i] == '5')
                        {
                            wynik[j, 3 * i + k] = pięć[j, k];
                        }
                        else if (cyfry[0][i] == '6')
                        {
                            wynik[j, 3 * i + k] = sześć[j, k];
                        }
                        else if (cyfry[0][i] == '7')
                        {
                            wynik[j, 3 * i + k] = siedem[j, k];
                        }
                        else if (cyfry[0][i] == '8')
                        {
                            wynik[j, 3 * i + k] = osiem[j, k];
                        }
                        else if (cyfry[0][i] == '9')
                        {
                            wynik[j, 3 * i + k] = dziewięć[j, k];
                        }
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < cyfry[0].Length * 3; j++)
                {
                    Console.Write(wynik[i, j]);
                }
                Console.WriteLine();
            }



        }
    }
}