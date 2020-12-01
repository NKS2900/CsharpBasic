using System;
using System.Collections.Generic;
using System.Text;

namespace DayFirstApp
{
    class BlindMagic
    {
        public static void BlindObj()
        {
            bool flag = true;
            do
            {
                Random random = new Random();
                int rand = random.Next(1, 11);
                Console.WriteLine("Enter Num Between 1-10: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (rand < num)
                    Console.WriteLine("random no is less than ur num...");
                else if (rand > num)
                    Console.WriteLine("random no is Greater Than ur num...");
                else if (rand == num)
                {
                    Console.WriteLine($"Ur num and random no is equals {rand} = {num}");
                    flag = false;
                }
            }
            while (flag);
        }
    }
}
