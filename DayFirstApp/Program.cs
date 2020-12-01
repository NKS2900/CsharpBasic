using System;

namespace DayFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
                   
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1. User_Input\n2. Find_Squre\n3. Leap_Year\n4. Blind_Number\n5. Tic_Tac_Toe\n6. Merge_Sort");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                         UserInput.UserObj();
                         break;
                    case 2:
                         SquareApp.SquareObj();
                         break;
                    case 3:
                        LeapYearApp.LeapYear();                    
                        break;                  
                    case 4:
                        BlindMagic.BlindObj();
                        break;
                    case 5:
                        TicTacToeApp.mainMethod();
                        break;
                    case 6:
                       // MergeSort.mergeMain();
                        break;
                    default:
                        Console.WriteLine("Invalid option...");
                        break;
                }
        }      
    }
}
