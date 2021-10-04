using System;
using static System.Console;

namespace BAEKJOON_1193
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = 0;
            int[] arr2 = 0;



            for (int i = 1; i < num; i++)
            {
                for (int j = i; j <= i; j--)
                {
                    if (j >= 1)
                    {
                        for (int a = 0; a < num; a++)
                        {
                            arr1[a] = j;
                        }
                    }

                }
                return arr1[num-1];
            }
;

            

                for (int k = 1; k < num; k++)
                {
                    for (int l = 1; l < k + 1; l++)
                    {
                        for (int b = 0; b < num; b++)
                        {
                            arr2[b] = l;
                        }
                    }
                    return arr2[num-1];
                }

                

            int num = int.Parse(ReadLine());

            Console.WriteLine($"(arr1[num-1])/(arr2[num-1])");
            
        }
    }
}
