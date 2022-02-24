using System;
using System.Text;
using System.Linq;
namespace Lesson1
{
    class Program
    {
        public static void Main(string[] arg)
        {
            Console.InputEncoding = Encoding.UTF8; 
            Console.OutputEncoding = Encoding.UTF8; 

            // VÍ DỤ VỀ TOÁN TỬ SO SÁNH LOGIC
            Console.WriteLine("*** VÍ DỤ VỀ TOÁN TỬ SO SÁNH LOGIC ***");
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

            Console.Write("Nhập vào số nguyên dương bất kỳ : ");
            int n001 = Convert.ToInt32(Console.ReadLine());
            switch (n001 % 2)
            {
                case 0:
                    Console.WriteLine($"{n001} là số chẵn");
                break;
                case 1:
                    Console.WriteLine($"{n001} là số lẻ");
                break;
            }


            // VÍ DỤ VỀ VÒNG LẶP
            Console.WriteLine("*** VÍ DỤ VỀ VÒNG LẶP ***");
            Console.Write("Nhập vào số nguyên dương bất kỳ : ");
            int n0001 = Convert.ToInt32(Console.ReadLine());
            for(;n0001<=100;n0001=n0001+10)
            {
                Console.WriteLine($"{n0001}");
            }
                // Lỗi Vòng lặp vô tận
                // for (;;)
                // {
                // }
            Console.Write("Nhập vào số nguyên dương bất kỳ : ");
            int n0002 = Convert.ToInt32(Console.ReadLine());
            while (n0002 <= 100)
            {
                Console.WriteLine($"{n0002}");   
                n0002+=50;          
            }

            Console.Write("Nhập vào số nguyên dương bất kỳ : ");
            int n0003 = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine($"{n0003}");   
                n0003+=100;        
            }
            while (n0003 <= 10000);          


             // VÍ DỤ VỀ CẤU TRÚC MẢNG, DỮ LIỆU MẢNG
            Console.WriteLine("*** VÍ DỤ VỀ CẤU TRÚC MẢNG, DỮ LIỆU MẢNG ***");

            string[] hangDienThoai = {"iPhone","Samsung", "Nokia"};
            ///string[] hangDienThoai = new string[3] {"iPhone","Samsung", "Nokia"};
            Console.WriteLine($"{hangDienThoai[0]}");
            Console.WriteLine($"{hangDienThoai[1]}");
            Console.WriteLine($"{hangDienThoai[2]}");

            // string[] hangDienThoai = {"iPhone","Samsung", "Nokia"};
            double[] giaDienThoai = {35000000, 15000000, 10000000};
            var giaDienThoaiiPhone = string.Format("{0:n0}",giaDienThoai[0]);
            var giaDienThoaiSamsung = string.Format("{0:n0}",giaDienThoai[1]);
            var giaDienThoaiNokia = string.Format("{0:n0}",giaDienThoai[2]);
            Console.WriteLine($"{hangDienThoai[0]} có giá là {giaDienThoaiiPhone}");
            Console.WriteLine($"{hangDienThoai[0]} có giá là {giaDienThoaiSamsung}");
            Console.WriteLine($"{hangDienThoai[0]} có giá là {giaDienThoaiNokia}");
            // Console.WriteLine($"{hangDienThoai[0]} có giá là {giaDienThoai[0]}");
            // Console.WriteLine($"{hangDienThoai[1]} có giá là {giaDienThoai[1]}");
            // Console.WriteLine($"{hangDienThoai[2]} có giá là {giaDienThoai[2]}");
            Console.WriteLine(hangDienThoai.Length);
            Console.WriteLine(hangDienThoai.Rank);
            // var giaDienThoaiCopy= giaDienThoai[2].Clone();
            // Console.WriteLine(giaDienThoaiCopy);
            Console.WriteLine(giaDienThoai.GetValue(0));
            Console.WriteLine(giaDienThoai.Max());
            Console.WriteLine(giaDienThoai.Min());
            Console.WriteLine(giaDienThoai.Sum());
            
            // VÍ DỤ VỀ PHƯƠNG THỨC
            Console.WriteLine("*** VÍ DỤ VỀ PHƯƠNG THỨC ***");
        }
    }
}