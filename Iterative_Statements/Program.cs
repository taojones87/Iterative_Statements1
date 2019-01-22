using System;

namespace Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value between 1 and 100.");

            try
            {
                // Gather the input value and convert to string variable.
                string input = Console.ReadLine();
                int value = int.Parse(input);

                // Run the for loop for the iteration.

                for (int i = 0; i <= value; i++)
                {
                    Console.WriteLine("You have entered " + input + ". This is the current integer value in the loop: " + i.ToString());
                }
            }
            catch
            {
                // Remind user of parameters and provide program close instructions.
                Console.WriteLine("Please run the program again and remember to enter an integer value between 1 and 100.");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
            // Provide program close instructions.
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);
        }
    }
}
