using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            starters:

            Console.WriteLine("Enter the first number to multiply: ");
            int numA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number to multiply: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            int result02 = Multiply(numA, numB);
            Console.WriteLine(result02);

            if(result02 % 2 == 0)
            {
                Console.WriteLine("Even");
            } else
            {
                Console.WriteLine("Odd");
            }
            
            part1:
            Console.WriteLine("Would you like to mutiply again? (y/n)");

            string answer = Console.ReadLine();

            if(answer == "y")
            {
                goto starters;
            } else if(answer == "n")
            {
                Console.WriteLine("we will continue to the next part");
            } else
            {
                Console.WriteLine("Invalid input try again");
                goto part1;
            }


            Console.WriteLine("Enter a sentence: ");

            string sentence = Console.ReadLine();

            Splitter(sentence);


            

            Console.ReadKey();
        }

        static int Multiply(int num01, int num02)
        {
            int result = num01 * num02;
            return result;
        }

        static int Splitter(string myString)
        {
            int wordCount = myString.Split(' ').Length;

            Console.WriteLine("There are " + wordCount + " words in that sentence.");
            return wordCount;
        }
    }
}