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
            int n1 = int.Parse(Console.ReadLine());
            // if (n1=0)
            // {
            //     Console.WriteLine("So 0 co ky so la 0 ");
            // }
            // else if (n1=1000)
            // {
            //     Console.WriteLine("So 1000 co ky so la 1,0,0,0");
            // }
            int n2 = n1;
            int t1 = n2%10;
            n2=n2/10;
            int t2 = n2%10;
            n2=n2/10;
            int t3 = n2%10;
            Console.WriteLine($"So {n1} co ky so la {t1},{t2},{t3}");     

            // BÀI TẬP 5
                   
        }
    }
}
