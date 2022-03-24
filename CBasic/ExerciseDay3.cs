using System;
using System.Text;
namespace CBasic
{
    class ExerciseDay3
    {
        public static void Main(string[] arg)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

        
            // Nhập số tuổi của 1 người và đưa ra kết luận theo quy tắc 
            // 0-2:trẻ sơ sinh,2-10:nhi đồng,10-17:vị thành niên,17-39:thanh niên,39-50:trung niên,>50:cao niên
            
            /* int age;
            bool isNumber = true;
            const string stop = "N";
            string comfirm = "Y";
            do
            {
                do
                {
                    Console.Write("Enter your age :");
                    isNumber = int.TryParse(Console.ReadLine(), out age);
                }
                while (!isNumber || age <= 0);
                if (age <= 2)
                {
                    Console.WriteLine("You are a baby");
                }
                else if (age <= 10)
                {
                    Console.WriteLine("You are a children");
                }
                else if (age <= 17)
                {
                    Console.WriteLine("You are a teenager");
                }
                else if (age <= 39)
                {
                    Console.WriteLine("You are a youth");
                }
                else if (age <= 50)
                {
                    Console.WriteLine("You are a middle-ager");
                }
                else
                {
                    Console.WriteLine("You are a old-ager");
                }
                Console.Write("Do you want to continue? (Y/N) : ");
                comfirm = Console.ReadLine().ToUpper();
            }
            while (comfirm != stop); */

       

            /* int year;
            const int cYear = 2022;
            int nYear = 0;
            bool isNumber = true;
            const string stop = "N";
            string comfirm = "Y";
            do
            {
                do
                {
                    Console.Write("Enter year of manufacture :");
                    isNumber = int.TryParse(Console.ReadLine(), out year);
                    nYear = cYear - year ;
                }
                while (!isNumber || year <= 0);
                if (nYear >= 15)
                {
                    Console.WriteLine("Thay The");
                }
                else if (nYear >= 10)
                {
                    Console.WriteLine("Bao Tri");
                }
                else
                {
                    Console.WriteLine("Khong co de xuat");
                }
                Console.Write("Do you want to continue? (Y/N) : ");
                comfirm = Console.ReadLine().ToUpper();
            }
            while (comfirm != stop); */
        
        
            double N;
            bool isNumber = true;
            bool isInt = true;
            const string stop = "N";
            string comfirm = "Y";
            do
            {
                do
                {
                    Console.Write("Enter a number :");
                    isNumber = double.TryParse(Console.ReadLine(), out N);
                    isInt = int.Parse(out N);
                }
                while (!isNumber);
                    
                if (isInt)
                {
                    Console.WriteLine($"{N} is integer Number");
                }
                Console.Write("Do you want to continue? (Y/N) : ");
                comfirm = Console.ReadLine().ToUpper();
            }
            while (comfirm != stop);

        }
    }
}