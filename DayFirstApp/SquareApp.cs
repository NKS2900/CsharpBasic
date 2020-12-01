using System;
using System.Collections.Generic;
using System.Text;

namespace DayFirstApp
{
    class SquareApp
    {
        public static void SquareObj()
        { 
            Console.WriteLine("Enter no. To Find Square");
            int no = Convert.ToInt32(Console.ReadLine());
            int sq = no * no;
            Console.WriteLine($"Squre {no}*{no} : {sq}");
        }
    }
}
