using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //User is greeted to the program

            Console.WriteLine("Hello! Welcome to the Number Factorial Calculator!!");

            // Prompts user to enter integer to begin interaction

            string Continue;

            do
            {

                Console.WriteLine("Please enter a number between 1-20");


                int userInput = int.Parse(Console.ReadLine());

                // using long factorial to hold larger integers

                long factorial = 1;


                for (int i = 0; i < userInput; i++)
                {
                    // Using recursion, this will calculate the factorial by multiplying to the previous factorial
                    factorial = (userInput - i) * factorial;

                }

                Console.WriteLine("The factorial of {0} is: {1}", userInput, factorial);
                Console.WriteLine("\n");
                Console.WriteLine("\n");

                // User is prompted to continue if they choose
                Console.WriteLine("Continue? (Y/N):");

                Continue = Console.ReadLine().ToLower();


            } while (Continue == "y" || Continue == "yes");

        }
    }
}
