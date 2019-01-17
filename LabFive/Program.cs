using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!");
            do
            {
                int fact = ValidInteger();
                Factorial(fact);

            } while (RunAgain());

        }

        private static void Factorial(int fact)
        {
            int temp = 1;
            for(int i = 1; i <= fact; i++)
            {
                temp *= i;
            }
            Console.WriteLine("The factorial of " + fact + " is " + temp);
        }

        public static int ValidInteger()
        {
            String input;
            bool validInput;
            int inputNum;

            Console.Write("Please Enter an integer that's greater than 0 but less than 10: ");

            do
            {
                input = Console.ReadLine();
                validInput = int.TryParse(input, out inputNum);
                if (!validInput)
                {
                    Console.WriteLine("Please type a valid Number");
                    validInput = false;
                }
                else if (inputNum > 10)
                {
                    Console.WriteLine("Please type a number less than ten.");
                    validInput = false;
                }
                else if (inputNum < 1)
                {
                    Console.WriteLine("Please type a number greater than zero.");
                    validInput = false;
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);

            return inputNum;
        }

        private static bool RunAgain()
        {
            string input;
            bool correctRespone = true;
            while (correctRespone)
            {
                Console.Write("Would you like to run the application again? (y/n):");
                input = Console.ReadLine().ToLower();
                if (String.Equals("n", input))
                {
                    correctRespone = false;
                    Console.WriteLine("Goodbye.");
                    return false;
                }
                else if (String.Equals("y", input))
                {
                    Console.WriteLine("Starting Over.");
                    Console.WriteLine("");
                    correctRespone = false;
                    return true;
                }
                else
                {
                    Console.WriteLine("That is an invalid entry!");
                    continue;
                }
            }
            return false; //should never get hit needed to make it happy.
        }
    }
}
