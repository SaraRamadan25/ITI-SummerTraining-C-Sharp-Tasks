using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Simple Calculator Menue");

            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Calculate Sum");
            Console.WriteLine("2. Find Maximum");
            Console.WriteLine("3. Find Minimum");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid choice (1, 2, or 3).");
                return;
            }

            switch (choice)
            {
                case 1:
                    CalculateSum();
                    break;
                case 2:
                    FindMaximum();
                    break;
                case 3:
                    FindMinimum();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
            }

            Console.WriteLine("Thank you for using Simple Calculator!");
        }


        static void CalculateSum()
        {
            Console.Write("Enter the first integer: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the second integer: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            int sum = num1 + num2;
            Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
            Console.ReadLine();
        }

        static void FindMaximum()
        {
            Console.Write("Enter the first integer: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the second integer: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            int max = Math.Max(num1, num2);
            Console.WriteLine($"Maximum of {num1} and {num2} is: {max}");
            Console.ReadLine();

        }

        static void FindMinimum()
        {
            Console.Write("Enter the first integer: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the second integer: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            int min = Math.Min(num1, num2);
            Console.WriteLine($"Minimum of {num1} and {num2} is: {min}");

            Console.ReadLine();
        }


    
}
}
