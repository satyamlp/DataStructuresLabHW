using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        public static void TestLeapYear()
        {
            string str = "S";
            while (str != "E")
            {
                Console.WriteLine("Enter a year");
                str = Console.ReadLine();
                if (str != "E")
                {
                    int year = Convert.ToInt32(str);
                    bool res = MyDate.IsLeapYear(year);
                    if (res)
                    {
                        Console.WriteLine("{0} IS leap year", year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is NOT LEAP YEAR", year);
                    }
                }
            }
        }

        public static void TestDate()
        {
            string str = "S";
            while (str != "E")
            {
                Console.WriteLine("Enter a date to find out if BEFORE or AFTER today");
                str = Console.ReadLine();
                if (str != "E")
                {
                    DateTime dt = Convert.ToDateTime(str);
                    if (MyDate.IsBefore(dt))
                    {
                        Console.WriteLine("{0} is BEFORE today", dt);
                    }
                    else
                    {
                        Console.WriteLine("{0} is AFTER today", dt);
                    }
                }
            }
        }

        public static void TestDaysInYear()
        {
            string str = "S";
            while (str != "E")
            {
                Console.WriteLine("Enter a date to find out the Nth day");
                str = Console.ReadLine();
                if (str != "E")
                {
                    DateTime dt = Convert.ToDateTime(str);
                    int nthDay = MyDate.DayInYear(dt);
                    Console.WriteLine("It is the {0}th day of the year", nthDay);
                }
            }
        }
                static void Main(string[] args)
                {
                    TestLeapYear();
                    TestDate();
                    TestDaysInYear();
                }           
    }
}
