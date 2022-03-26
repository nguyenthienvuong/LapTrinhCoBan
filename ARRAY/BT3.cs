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

            //Nhập dữ liệu Mảng hai chiều
            int M, N;
            Console.Write("Please enter size of column of 2-way array : ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Please enter size of row of 2-way array : ");
            N = int.Parse(Console.ReadLine());
            float[,] array2 = new float[M, N];
            for (int i = 0; i < M
            ; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($" Please enter the array2[{i}, {j}] element : ");
                    array2[i, j] = float.Parse(Console.ReadLine());
                }
            }

            //Xuất mảng 2 chiều
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine();
            }

            //1.Tổng dương
            float sum = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (array2[i, j] > 0)
                    {
                        sum = sum + array2[i, j];
                    }
                }
            }
            Console.WriteLine($"Sum of all posstive float element of array : {sum}");

            //2. Tổng mà i+j chia hết cho 5
            float sum5 = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i+j) % 5 == 0)
                    {
                        sum5 = sum5 + array2[i, j];
                    }
                }
            }
            Console.WriteLine($"Sum of all float at (i+j)%5==0 element of array : {sum5}");
        }
    }
}