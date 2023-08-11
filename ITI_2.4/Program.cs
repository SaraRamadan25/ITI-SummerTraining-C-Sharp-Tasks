using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Max Number Calculator!");

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

            Console.WriteLine($"The maximum of {num1} and {num2} is: {max}");

            Console.ReadLine();
        }
    }
}
