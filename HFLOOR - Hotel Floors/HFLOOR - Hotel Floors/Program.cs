using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFLOOR___Hotel_Floors
{
    class Program
    {
        static void Main(string[] args)
        {
            int NOTC = int.Parse(Console.ReadLine());
            for (int b = 0; b < NOTC; b++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int M = int.Parse(input[0]);
                int N = int.Parse(input[1]);
                char[][] arr = new char[M][];
                for (int i = 0; i < M; i++)
                {
                    arr[i] = new char[N];
                    arr[i] = Console.ReadLine().ToCharArray();
                }
                int Gosc = 0;
                int Pokoj = 0;
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (arr[i][j] == '-' || arr[i][j] == '*')
                        {
                            Pokoj += 1;
                            Test(arr, i, j, ref Gosc);
                        }
                    }
                }
                Console.WriteLine((1f * Gosc / Pokoj).ToString("F"));
            }
        }
        static void Test(char[][] arr, int B, int C, ref int Gosc)
        {
            if (arr[B][C] == 'v' || arr[B][C] == '#') return;
            if (arr[B][C] == '*') Gosc += 1;
            arr[B][C] = 'v';
            Test(arr, B + 1, C, ref Gosc);
            Test(arr, B - 1, C, ref Gosc);
            Test(arr, B, C + 1, ref Gosc);
            Test(arr, B, C - 1, ref Gosc);
        }
    }
}
