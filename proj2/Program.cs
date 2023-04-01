using System;  

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press R to start the program");

            string input = Console.ReadLine();

            string lowerInput = input.ToLower();

            if (input == lowerInput || input == "R")
            {
                Console.WriteLine("Program started");

                Console.WriteLine("Press ENTER to roll the dice");

                Console.ReadLine();

                Random random = new Random();

                int dice1 = 1;
                int dice2 = 0;
                int attempts = 0;

                while(dice1 != dice2)
                {
                    Console.WriteLine("Press ENTER to roll the dice");
                    Console.ReadKey();
                    
                    dice1 = random.Next(1, 7);
                    dice2 = random.Next(1, 7);

                    Console.WriteLine("Dice 1: " + dice1);
                    Console.WriteLine("Dice 2: " + dice2);

                    attempts++;
                }

                Console.WriteLine("You rolled the dice " + attempts + " times to get matching numbers");
            }
            else
            {
                Console.WriteLine("Program not started");
            }

            Console.ReadKey();

        }
    }
}