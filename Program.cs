using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 2 and 10.");
            Console.WriteLine("(Please round to the nearest whole number)");

            string UserInput;
            int Number;
            int i;
            UserInput = Console.ReadLine();
            Console.WriteLine(" You entered: " + UserInput);

            if (!Int32.TryParse(UserInput, out Number))
            {
                Console.WriteLine("Invalid data input");
            }
            else if ((Number < 2) || (Number > 10))
            {
                Console.WriteLine("Error message: Out of range: Enter a number between 2 and 10");
            }
            else if (Number % 2 == 1)
            {
                for (i = 2; i <= Number; i++)
                {
                    Console.WriteLine("You entered an odd number");
                }
            }
            else if (Number % 2 == 0)
            {
                for (i = 0; i <= Number; i++)
                {
                    Console.WriteLine("You entered an even number");
                }
            }
        }
    }
}
