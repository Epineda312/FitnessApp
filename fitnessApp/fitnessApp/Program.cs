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
          //Variables
        double runningTotal = 0;
        bool keepGoing = true;
          
        //Loop Starts
        while(keepGoing)
        {
          //Prompt the user for minutes exercised
          Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");         
          
          //Take user input and set it as a variable
          string entry = Console.ReadLine();
          
          //Main Logic Loop
          if(entry.ToLower() == "quit")
          {
            keepGoing = false;
          }
          else
          {                      
            //Try Catch Block Starts
            try
            {
                //Parse the user input to hold as an integer
                double minutes = double.Parse(entry);
                
                if(minutes <= 0)
              {
                Console.WriteLine(minutes + " is not an acceptable value.");
                continue;
              }
              if(minutes <= 10)
              {
                Console.WriteLine("Better than nothing");
              }
              else if(minutes <= 30)
              {
                Console.WriteLine("Way to go!");
              }
              else if(minutes <= 60)
              {
                Console.WriteLine("Ninja in training!");
              }
              else
              {
                Console.WriteLine("Okay, now your just showing off!");
              }
              //Add minutes exercised to total
              runningTotal = runningTotal + minutes;
            }
            catch(FormatException)
            {
              Console.WriteLine("That was not valid input.");
              continue;
            }                                     
            //Display total minutes exercised to the screen
            Console.WriteLine("You've entered " + runningTotal + " minutes");      
           }            
         }
          //Text Displayed When User Quits 
          Console.WriteLine("see ya!");
       }
    }
  } 
  
