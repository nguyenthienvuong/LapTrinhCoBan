using System;
using System.Text;
namespace Lesson1
{
    class Program
    {
        public static void Main(string[] arg)
        {
            Console.InputEncoding = Encoding.UTF8; 
            Console.OutputEncoding = Encoding.UTF8; 

            // VÍ DỤ VỀ TOÁN TỬ
            Console.Write("Nhập vào 1 số nguyên dương bất kỳ : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if((n%2)==0)
            {
                Console.WriteLine($"{n} là số chẵn");
            }
            else
            {
                Console.WriteLine($"{n} là số lẻ");
            }

            
        }
    }
}