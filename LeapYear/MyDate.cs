using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    public static class MyDate
    {
        public static bool IsLeapYear(int year)
        {
            if (year <= 0)
                throw new System.IndexOutOfRangeException();

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                return true;
            }
            return false;
        }

        public static bool IsBefore(DateTime d)
        {
            bool ret = false;
            DateTime today = DateTime.Now;

            if (d.Ticks < today.Ticks)
            {
                Console.WriteLine("{0} is the difference", d.Ticks - today.Ticks);
                ret = true;
            }
            return ret;
        }

        public static bool IsAfter(DateTime d)
        {
            bool ret = false;
            DateTime today = DateTime.Now;

            if (d.Ticks > today.Ticks)
            {
                ret = true;
            }
            return ret;
        }

        public static int DaysInaMonth(int month, int year)
        {
            int days = 31;
            
            if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
            {
                // 30 days in sept=9, april=4, june=6, nov=11
                days = 30;
            }
            else if (month == 2)
            {
                if (IsLeapYear(year))
                {
                    days = 29;
                }
                else
                {
                    days = 28;
                }
            }
            return days;
        }
        /// </summary> 
        /// <returns>returns a number 1...366, inclusive, such that this Date is the nth day of its year.</returns> 
        public static int DayInYear(DateTime date)
        {
            int month = date.Month;
            int day = date.Day;
            int year = date.Year;

            if (month == 1)
                return day;

            int prevMonthDays = 0; 
            for (int i=1; i<month; i++)
            {
                prevMonthDays += DaysInaMonth(i, year);
            }
            prevMonthDays += day;
            return prevMonthDays;
        }


    }
}
