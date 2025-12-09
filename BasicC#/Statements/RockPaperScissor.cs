using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Statements
{
    internal class RockPaperScissor
    {
        public void game()
        {
            Console.WriteLine("Rock = 1, Paper = 2, Scissors = 3");
            Console.Write("Enter your choice (1/2/3): ");
            int user = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int computer = rand.Next(1, 4); // 1 to 3

            Console.WriteLine($"Computer chose: {computer}");

            
            if (user == computer)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (user == 1 && computer == 3)
            {
                Console.WriteLine("You win! Rock beats Scissors.");
            }
            else if (user == 2 && computer == 1)
            {
                Console.WriteLine("You win! Paper beats Rock.");
            }
            else if (user == 3 && computer == 2)
            {
                Console.WriteLine("You win! Scissors beat Paper.");
            }
            else if (user >= 1 && user <= 3)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
