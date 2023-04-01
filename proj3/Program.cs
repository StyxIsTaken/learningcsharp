using System;
using System.Collections.Generic;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            Console.WriteLine("How many people do you want to add to the list?");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the " + numberOfPeople + " peoples names:");

            for (int i = 0; i < numberOfPeople; i++)
            {
                string name = Console.ReadLine();
                myList.Add(name);
            }

            // Display the list in alphabetical order
            myList.Sort();

            Console.WriteLine("The list of people in alphabetical order is:");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.ReadKey();
        }
    }
}