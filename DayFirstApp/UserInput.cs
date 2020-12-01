using System;
using System.Collections.Generic;
using System.Text;

namespace DayFirstApp
{
    class UserInput
    {
        public static void UserObj()
        {
                Console.Write("Enter Your Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Hello " + name);

                Console.WriteLine("Enter Two no :");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Addition    : " + (a + b));           
        }
    }
}
