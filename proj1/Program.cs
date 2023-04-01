// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //console stuff
            Console.Title = "Ticket Stand";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;
            
            float ticketPrice = 5.00f;

            Console.WriteLine("Tickets are $5 each.");
            Console.WriteLine("How many tickets would you like to buy?");
            int ticketAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ticketAmount + " Will cost you $" + ticketPrice * ticketAmount);
            Lbozo:
            Console.WriteLine("Please insert your money.");
            
            //money stuff
            double ticketCost = ticketPrice * ticketAmount;
            double money = Convert.ToDouble(Console.ReadLine());

            if (money < ticketCost)
            {
                Console.WriteLine("You do not have enough money. please insert more money.");
                goto Lbozo;
            }
            else if (money > ticketCost)
            {
                double change = money - ticketCost;
                Console.WriteLine("Thank you for your purchase! Your change is $" + change);
            }
            else
            {
                Console.WriteLine("You have the exact amount of money. Thank you for your purchase!");
            }


            Console.ReadKey();
        }
    }
}