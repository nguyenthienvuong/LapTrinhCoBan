using System;
using System.Text;
namespace Array
{
    class BT3
    {
        public static void Main(string[] arg)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //Mảng hai chiều
            int M,N;
            Console.Write("Please enter size of column of 2-way array : ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Please enter size of row of 2-way array : ");
            N = int.Parse(Console.ReadLine());
            float[,] array2 = new float[M,N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($" Please enter the array2[{i}, {j}] element : ");
                    array2[i, j] = float.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(array2);

        }
    }
}