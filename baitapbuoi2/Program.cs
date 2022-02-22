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
            // BÀI TẬP 1
            Console.WriteLine("Ngon ngu lap trinh C");

            // BÀI TẬP 2
            int n;
            n=100;
            Console.WriteLine(n);
            n=n+200;
            Console.WriteLine(n);
            
            // BÀI TẬP 3
            //1
            Console.WriteLine("*");
            Console.WriteLine("* *");
            Console.WriteLine("* * *");
            Console.WriteLine("* * * *");
            Console.WriteLine("* * * * *");

            // for(int i=0;i<5;i++)
            // {
            //     Console.Write("*");
            //     // for(int j=0;j<=i;j++);
            //     // {
            //     // }
            // Console.WriteLine("\n"); 
            // }

            //2
            Console.WriteLine("* * * * *");
            Console.WriteLine("* * * *");
            Console.WriteLine("* * *");
            Console.WriteLine("* *");
            Console.WriteLine("*");
            
            //3
            Console.WriteLine("        *");
            Console.WriteLine("      * *");
            Console.WriteLine("    * * *");
            Console.WriteLine("  * * * *");
            Console.WriteLine("* * * * *");

            //4
            Console.WriteLine("* * * * *");
            Console.WriteLine("  * * * *");
            Console.WriteLine("    * * *");
            Console.WriteLine("      * *");
            Console.WriteLine("        *");

            //5
            Console.WriteLine("        * ");
            Console.WriteLine("      * * * ");
            Console.WriteLine("    * * * * * ");
            Console.WriteLine("  * * * * * * * ");
            Console.WriteLine("* * * * * * * * *");
            
            //6
            Console.WriteLine("* * * * * * * * *");
            Console.WriteLine("  * * * * * * * ");
            Console.WriteLine("    * * * * * ");
            Console.WriteLine("      * * * ");
            Console.WriteLine("        * ");

            //7
            Console.WriteLine("* * * * * * * * *");
            Console.WriteLine("  * * * * * * * ");
            Console.WriteLine("    * * * * * ");
            Console.WriteLine("      * * * ");
            Console.WriteLine("        * ");
            Console.WriteLine("        * ");
            Console.WriteLine("      * * * ");
            Console.WriteLine("    * * * * * ");
            Console.WriteLine("  * * * * * * * ");
            Console.WriteLine("* * * * * * * * *");

            // BÀI TẬP 4
            Console.Write("Nhap vao so nguyen duong bat ky tu 0 den 1000 : ");
            int n1 = int.Parse(Console.ReadLine());
            // if (n1=0)
            // {
            //     Console.WriteLine("So 0 co ky so la 0 ");
            // }
            // else if (n1=1000)
            // {
            //     Console.WriteLine("So 1000 co ky so la 1,0,0,0");
            // }
            // else if (0 <= n1 <= 1000)
            // {
            int n2 = n1;
            int t1 = n2%10;
            n2=n2/10;
            int t2 = n2%10;
            n2=n2/10;
            int t3 = n2%10;
            Console.WriteLine($"So {n1} co ky so la {t3},{t2},{t1}");     
            // }
            // else
            // {
            // Console.WriteLine("Dieu kien nhap khong thoa man");        
            // }

            // BÀI TẬP 5
            Console.Write("Nhap diem thi lan 1 (25%): ");
            float dt1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem thi online (25%) : ");
            float dt2 = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem thi lan cuoi ky (50%) : ");
            float dt3 = float.Parse(Console.ReadLine());
            float dtb = (dt1*25/100) + (dt2*25/100) + (dt3*50/100);
            Console.WriteLine($"Diem trung binh là : {dtb}");

            // BÀI TẬP 6
            Console.Write("Nhap chieu dai tam giac vuong : ");
            double cd = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong tam giac vuong : ");
            double cr = float.Parse(Console.ReadLine());
            double ch = Math.Sqrt(cd*cd + cr*cr);
            double cv = cd + cr + ch; // chu vi= cd+cr+ch
            double dt = (cd * cr) / 2; // dien tich=1/2(cd*cr)
            Console.WriteLine($"Chu vi tam giac vuong la : {cv}");
            Console.WriteLine($"Dien tich tam giac vuong la : {dt}");

            // BÀI TẬP 7
            Console.Write("Nhap canh thu nhat : ");
            double c1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap canh thu hai : ");
            double c2 = float.Parse(Console.ReadLine());
            Console.Write("Nhap canh thu ba : ");
            double c3 = float.Parse(Console.ReadLine());
            double cv2 = c1 + c2 + c3; // chu vi= cd+cr+ch
            Console.WriteLine($"Chu vi hinh tam giac la: {cv2}");
            double nuacv=cv2/2;
            double dientich2 = Math.Sqrt(nuacv*(nuacv-c1)*(nuacv-c2)*(nuacv-c3)); // dien tich = cong thuc Heron
            Console.WriteLine($"Dien tich hinh tam giac la: {dientich2}");
        }
    }
}
