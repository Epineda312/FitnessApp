using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 0;

            bool keepGoing = true;
            while (keepGoing)
            {
                // Prompt user for minutes exercised 
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    // Add minutes exercised to total 
                    int minutes = int.Parse(entry);
                    runningTotal = runningTotal + minutes;

                    // Display total minutes exercised to the screen 
                    Console.WriteLine("You've entered " + runningTotal + " minutes.");
                }
                // Repeat until user quits
            }

            Console.WriteLine("Goodbye");

        }
        }
}
