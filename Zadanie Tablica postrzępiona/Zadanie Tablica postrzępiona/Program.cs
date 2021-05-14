using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Tablica_postrzępiona
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] jagged = ReadJaggedArrayFromStdInput();
            PrintJaggedArrayToStdOutput(jagged);
            jagged = TransposeJaggedArray(jagged);
            Console.WriteLine();
            PrintJaggedArrayToStdOutput(jagged);
        }

        static char[][] ReadJaggedArrayFromStdInput()
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] jagged = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine().Replace(" ", "");
                jagged[i] = input.ToCharArray();
            }

            return jagged;
        }

        static void PrintJaggedArrayToStdOutput(char[][] tab)
        {
            foreach (char[] row in tab)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        static char[][] TransposeJaggedArray(char[][] tab)
        {
            int rows = 0;
            foreach (char[] row in tab)
            {
                if (row.Length > rows) rows = row.Length;
            }

            char[][] jagged = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                jagged[i] = new char[tab.Length];
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < tab.Length; j++)
                {
                    try
                    {
                        jagged[i][j] = tab[j][i];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        jagged[i][j] = ' ';
                    }

                }
            }

            return jagged;
        }
    }
}
