using System;
using System.Text;
namespace CBasic
{
    class LearnDay3
    {
        public static void Main(string[] arg)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

        /*
            double roomPrize = 0;

            string roomKind;
            int day;
            bool isNumber = true;
            const int priceRoomA = 500000;
            const string roomA = "A";
            const int priceRoomB = 500000;
            const string roomB = "B";
            const int priceRoomC = 500000;
            const string roomC = "C";
            const string stop = "N";
            string confirmed = "Y";
            do
            {

            do
            {
                Console.Write("Choose kind of room (A,B,C):");
                roomKind = Console.ReadLine().ToUpper();
            }
            while (roomKind != roomA && roomKind != roomB && roomKind != roomC );
            do
            {
                Console.Write("Choose number of day:");
                isNumber = int.TryParse(Console.ReadLine(), out day);
            }
            while (!isNumber || day < 0);

            if (roomKind == roomA)
            {
                double total = day * priceRoomA;
                Console.WriteLine($"Total money :{total}");
            }
            else if (roomKind == roomB)
            {
                double total = day * priceRoomB;
                Console.WriteLine($"Total money :{total.ToString("C2")}");
            }
            else if (roomKind == roomC)
            {
                double total = day * priceRoomC;
                Console.WriteLine($"Total money :{total}");
            }           
                Console.Write("Do you want to continue?(Y/N)");
                confirmed = Console.ReadLine().ToUpper();
            }
            while(confirmed != stop);
        */

        /* 
                Nhập vào ĐTB = value (0 <= ĐTB <=10)
                Hiển thị ra màn hình Xếp loại dựa vào ĐTB
                ĐTB >= 9 -> Xuất sắc
                ĐTB >= 8 -> Giởi
                ĐTB >= 7 -> Khá
                ĐTB >= 5 -> Trung bình
                Còn lại là yếu

                Sử dụng if...else
                Sử dụng toán tử 3 ngôi ? : 
                Sử dụng switch..case 
        */

        /*
            const string stop = "N";
            const string coutinue = "Y";
            string confirmed = coutinue;
            do
            {
                double aveScore = 0;
                bool isNumber = true;

                do
                {
                    Console.Write("Enter average score: ");
                    isNumber = double.TryParse(Console.ReadLine(), out aveScore);
                }
                while (!isNumber || aveScore < 0 || aveScore > 10);

                string result = "Excelence";
                if (aveScore < 5)
                {
                    result = "Bad";
                }
                if (aveScore >= 5 && aveScore < 7)
                {
                    result = "Medium";
                }
                if (aveScore >= 7 && aveScore < 8)
                {
                    result = "Good";
                }
                if (aveScore >= 8 && aveScore < 9)
                {
                    result = "Very Good";
                }
                Console.WriteLine(result);
                Console.Write("Are you want to countinue? (Y/N): ");
                confirmed = Console.ReadLine().ToUpper();
            }
            while (confirmed != stop);
        */

        /*
            Console.Write("Enter average score: ");
            isNumber = double.TryParse(Console.ReadLine(), out aveScore);
            while (!isNumber || aveScore < 0 || aveScore > 10)
            {
                Console.Write("Enter average score: ");
                isNumber = double.TryParse(Console.ReadLine(), out aveScore);
            }

            Console.Write("Enter average score: ");
            isNumber = double.TryParse(Console.ReadLine(), out aveScore);
            for (; !isNumber || aveScore < 0 || aveScore > 10;)
            {
                Console.Write("Enter average score: ");
                isNumber = double.TryParse(Console.ReadLine(), out aveScore);
            }

            if (aveScore >= 9)
            {
                Console.WriteLine("Excelence");
            }
            else if (aveScore >= 8)
            {
                Console.WriteLine("Very Good");
            }
            else if (aveScore >= 7)
            {
                Console.WriteLine("Good");
            }
            else if (aveScore >= 5)
            {
                Console.WriteLine("Medium");
            }
            else
            {
                Console.WriteLine("Bad");
            }

            if (aveScore >= 9)
            {
                Console.WriteLine("Excelence");
            }
            else
            {
                if (aveScore >= 8)
                {
                    Console.WriteLine("Very Good");
                }
                else
                {
                    if (aveScore >= 7)
                    {
                        Console.WriteLine("Good");
                    }
                    else
                    {
                        if (aveScore >= 5)
                        {
                            Console.WriteLine("Medium");
                        }
                        else
                        {
                            Console.WriteLine("Bad");
                        }
                    }
                }
            }
        */

            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // if (j <= i)
                    // {
                    //     Console.Write("* ");
                    // }
                    // else
                    // {
                    //     Console.Write("  ");
                    // }
                    Console.Write(j <= i ? "* " : "  ");
                }
                Console.WriteLine();
            }

            int n1 = 8, n2 = 10, n3 = 7;
            Console.Write("Max: " + ((n1 > n2 && n1 > n3) ? n1 : (n2 > n3) ? n2 : n3));
        }
    }
}