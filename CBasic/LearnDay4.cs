using System;
using System.Text;
namespace CBasic
{
    class LearnDay4
    {
        public static void Main(string[] arg)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            /* int[] number = new int []{1,2,3,4,5,6,7,8,9,10,11};
            Console.WriteLine(string.Join(',',number)); */
            /* for (int i=0; i< number.Length;i++)
            {
            Console.WriteLine(number[i]);               
            } */

            // string[] fruit = new string [5]{"A","B","C","D","E"};
            // string[] fruit = new string []{"A","B","C","D","E"};

            /* Console.Write("Enter your size:");
            int size= int.Parse(Console.ReadLine());
            int[] number = new int[size]; 
            for(int i=0;i<size;i++)
            {
                Console.Write($"Enter number {i}:");
                number[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(',',number)); */

            /* int[] number = new int[0];
            int n = 0;
            do
            {

                Console.Write($"Enter number:");
                n = int.Parse(Console.ReadLine());
                Array.Resize(ref number,number.Length+1);
                number[number.Length -1 ] = n;
            }
            while (n != 0);
            Console.WriteLine(string.Join(',',number)); */


            /*  int[] number;
             int size = 0;
             int min = 1;
             int max = 99;
             int MaxArray = 0;
             Console.Write($"Enter size:");
             size = int.Parse(Console.ReadLine());
             number = new int[size];
             Random rnd = new Random();
             for (int i = 0; i < size; i++)
             {
                 number[i] = rnd.Next(min, max);
             }
             for (int j=0; j< number.Length ; j++)
             {
                 if (MaxArray < number [j])
                 {
                     MaxArray = number [j];
                 }
             }

             Console.WriteLine(string.Join(',', number));
             Console.WriteLine($"Max Array is : {MaxArray}"); */


            /* int[] number;
            int size = 0;
            int min = 1;
            int max = 99;
            int MaxArray = 0;
            Console.Write($"Enter size:");
            size = int.Parse(Console.ReadLine());
            number = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                number[i] = rnd.Next(min, max);
            }
            Console.WriteLine(string.Join(',', number));
            Console.Write($"Enter value:");
            int value = int.Parse(Console.ReadLine());

            int inValue = -1;
            for (int j = 0; j < number.Length; j++)
            {
                if (value == number[j])
                {
                    inValue = j;
                    break;
                }
            }
            if (inValue != -1)
            {
                Console.WriteLine($"{value} is at {inValue} of the array");
            }
            else
                Console.WriteLine($"{value} don't have in the array"); */

            int[] number;
            int size = 0;
            int min = 1;
            int max = 99;
            int MaxArray = 0;
            Console.Write($"Enter size:");
            size = int.Parse(Console.ReadLine());
            number = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                number[i] = rnd.Next(min, max);
            }
            Console.WriteLine(string.Join(',', number));

            int soluongChan = 0;
            for (int j = 0; j < number.Length; j++)
            {
                if (number[j] % 2 == 0)
                {
                    soluongChan ++ ;
                }
            }
            Console.WriteLine($"So luong so chan trong mang la : {soluongChan}");
        }
    }
}