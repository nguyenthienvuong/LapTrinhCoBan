using System;
using System.Text;
namespace Array
{
    class BT7
    {
        public static void Main(string[] arg)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string dateStr;
            Console.WriteLine("Please enter the date with format yyyy mm dd : ");
            dateStr = Console.ReadLine();
            string[] dateArr = dateStr.Split(" ");
            int year = int.Parse(dateArr[0]);
            int month = int.Parse(dateArr[1]);
            int day = int.Parse(dateArr[2]);
            DateTime date = new DateTime(year, month, day);

            Console.WriteLine(date.DayOfWeek);


        }
    }
}
