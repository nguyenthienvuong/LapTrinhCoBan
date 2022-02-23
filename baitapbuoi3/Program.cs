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

            // VÍ DỤ VỀ TOÁN TỬ SO SÁNH LOGIC
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

            Console.Write("Nhập vào số nguyên dương thứ nhất : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập vào số nguyên dương thứ hai : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if( n1 == n2)
            {
                Console.WriteLine($"{n1} bằng {n2}");
            }
            else if (n1>n2)
            {
                Console.WriteLine($"{n1} lớn hơn {n2}");
            }
            else 
            {
                Console.WriteLine($"{n1} nhỏ hơn {n2}");
            }

            Console.Write("Nhập vào số tuổi của bạn : ");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            // var thongbao = (tuoi >=18 & tuoi <=65) ? "Đủ điều kiện học bằng lái":"Không đủ điều kiện học bằng lái";
            // Console.WriteLine(thongbao);
            Console.WriteLine((tuoi >=18 & tuoi <=65) ? "Đủ điều kiện học bằng lái":"Không đủ điều kiện học bằng lái");

            Console.Write("Nhập vào số nguyên dương thứ nhất : ");
            int n01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập vào số nguyên dương thứ hai : ");
            int n02 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập vào số nguyên dương thứ ba : ");
            int n03 = Convert.ToInt32(Console.ReadLine());
            int max = n01>=n02?n01>=n03?n01:n03:n02>=n03?n02:n03;
            Console.WriteLine($"Số lớn nhất là : {max}");

        }
    }
}