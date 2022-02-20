using System;
using System.Text;
namespace Lesson1
{
    class Program
    {
        public static void Main(string[] arg)
        {
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
            int n2 = int.Parse(Console.ReadLine());
            while (n2>=0 & n2<=1000)
            {
                int a=n2%10;
                n2=n2/10;
                Console.Write(a);
            }
        }
    }
}
