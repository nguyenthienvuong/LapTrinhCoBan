using System;
using System.Text;
namespace Array
{
    class BT2
    {
        public static void Main(string[] arg)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // 1.
            int N;
            Console.Write("Please enter an integer number, N = ");
            N = int.Parse(Console.ReadLine());
            //Console.WriteLine(N);

            //2.
            float[] arrayN = new float[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Please enter the {i + 1} (st/nd/rd/th) element : ");
                arrayN[i] = float.Parse(Console.ReadLine());
            }
            Console.Write("Array N: ");
            Console.WriteLine(String.Join(',', arrayN));

            //3.
            float max = arrayN[0];
            for (int i = 0; i < N; i++)
            {
                if (arrayN[i] > max)
                {
                    max = arrayN[i];
                }
            }
            Console.WriteLine($"The max element is : {max}");

            //4.
            float min = arrayN[0];
            for (int i = 0; i < N; i++)
            {
                if (arrayN[i] < min)
                {
                    min = arrayN[i];
                }
            }
            Console.WriteLine($"The min element is : {min}");

            //5. Max Even Possitive element
            float maxepn = arrayN[0];
            for (int i = 0; i < N; i++)
            {
                if (arrayN[i] > 0 && arrayN[i] % 2 == 0 && arrayN[i] > maxepn)
                {
                    maxepn = arrayN[i];
                }
            }
            Console.WriteLine($"The min even possitive element is : {maxepn}");

            //6. Min Odd Negative element : chưa xử lý nếu mảng không có số âm
            float minepn = arrayN[0];
            for (int i = 0; i < N; i++)
            {
                if (arrayN[i] < 0 && arrayN[i] % 2 != 0 && arrayN[i] < minepn)
                {
                    minepn = arrayN[i];
                }
            }
            Console.WriteLine($"The min odd negative element is : {minepn}");

            //7. Find perfect square elemnet
            Console.Write("The perfect square elements are : ");
            for (int i = 0; i < N; i++)
            {
                double temp = Math.Sqrt(arrayN[i]);
                if (temp * temp == arrayN[i])
                {
                    Console.Write($" {arrayN[i]} ");
                }
            }
            Console.Write("\n");

            //8. Sum of array
            float sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum = sum + arrayN[i];
            }
            Console.WriteLine($"Sum of element is : {sum}");

            //9. Average of array : ra kết quả sai
            
            /* for (int i = 0; i < N; i++)
            {
                sum = sum + arrayN[i];
            } */
            float ave = sum / N;
            Console.WriteLine(N);
            Console.WriteLine($"Average of element is : {ave}");

            //10. Find element > average
            Console.Write("The elements that bigger than average are: ");
            for (int i = 0; i < N; i++)
            {
                if (arrayN[i] > ave)
                {
                    Console.Write($" {arrayN[i]} ");
                }
            }
            Console.Write("\n");

            //11. Sort array in ascending order
            float temp2;
            for (int i = 0; i < N; i++)
            {
                for (int j = i+1; j < N; j++)
                {
                    if (arrayN[i] > arrayN[j])
                    {
                        temp2 = arrayN[i];
                        arrayN[i] = arrayN[j];
                        arrayN[j] = temp2;
                    }
                }
            }
            Console.Write("The array after sort in ascending order : ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{arrayN[i]}" + " ");
            }
            Console.Write("\n");

            //12. Sort array in descending order
            float temp3;
            for (int i = 0; i < N; i++)
            {
                for (int j = i+1; j < N; j++)
                {
                    if (arrayN[i] <= arrayN[j])
                    {
                        temp3 = arrayN[i];
                        arrayN[i] = arrayN[j];
                        arrayN[j] = temp3;
                    }
                }
            }
            Console.Write("The array after sort in descending order : ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{arrayN[i]}" + " ");
            }
            Console.Write("\n");
        }
    }
}