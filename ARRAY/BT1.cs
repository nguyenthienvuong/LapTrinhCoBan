using System;
using System.Text;
namespace Array
{
    class BT1
    {
        public static void Main(string[] arg)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo mảng dữ liệu a[] ,size N, có value là Random
            Console.Write("Please enter the size of array,N =  ");
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N];
            Random rad = new Random();
            for (int i = 0; i < N; i++)
            {
                a[i] = rad.Next(0, 11);
            }
            Console.WriteLine(String.Join(',', a));
            //Sắp xếp theo thứ tự tăng 
            int x;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (a[i] > a[j])
                    {
                        x = a[i];
                        a[i] = a[j];
                        a[j] = x;
                    }
                }
            }
            Console.Write("The array after sort from low to high : ");
            for (int i = 0; i < N; i++)
            {
                // Console.Write(String.Join("\n", a[i]));
                Console.Write($"{a[i]}" + " ");
            }
            //Loại bỏ các giá trị  trùng nhau
            Console.WriteLine("\n");
            Console.Write("The array after sort from low to high and remove the same value: ");
            for (int i = 1; i < N; i++)
            {               
                    if (a[i] == a[i-1] && a[i] == a[i+1])
                    {
                        // N--;
                        Console.Write($"{a[i]}" + " ");
                    }
                    else
                    {
                        Console.Write("T");
                    }           
            }
            
        }
    }
}
