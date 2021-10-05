using System;
using static System.Console;

namespace BAEKJOON_1193
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(ReadLine());

            int[] arr1 = new int[num];
            int[] arr2 = new int[num];

            for (int i = 1; i < num+1; i++)  // 분자
            {
                for (int j = i; j <= i; j--)
                {
                    if (j >= 1)
                    {
                        for (int a = 0; a < num+1; a++)
                        {
                            arr1[a] = j;
                        }
                    }
                }
            }
            
            for (int k = 1; k < num+1; k++)  // 분모
            {
                for (int l = 1; l < k + 1; l++)
                {
                    for (int b = 0; b < num+1; b++)
                    {
                        arr2[b] = l;
                    }
                }
            }
            Console.WriteLine($"{arr1[num-1]}/{arr2[num-1]}");
        }
    }
}
