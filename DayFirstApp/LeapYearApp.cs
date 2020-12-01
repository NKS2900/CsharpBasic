using System;
using System.Collections.Generic;
using System.Text;

namespace DayFirstApp
{
    class LeapYearApp
    {
        public static void LeapYear()
        {
            int year;
            Console.WriteLine("Input an year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
                Console.WriteLine(year + "is a leap year.\n");
            else if ((year % 100) == 0)
                Console.WriteLine(year + " is not a leap year.\n");
            else if ((year % 4) == 0)
                Console.WriteLine(year + "is a leap year.\n");
            else
                Console.WriteLine(year + " is not a leap year.\n");
        }
    }
}
