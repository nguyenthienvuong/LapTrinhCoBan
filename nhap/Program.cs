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

            
            string[] hangDienThoai = {"iPhone","Samsung", "Nokia"};
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

        }
    }
}