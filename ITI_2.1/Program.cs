using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_2._1
{
    class Program
    {
        static void Main(string[] args)
        {


            {
                Console.WriteLine("Sum and Average Integer Calculator");

                Console.Write("Enter the first number: ");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }

                Console.Write("Enter the second number: ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }

                int sum = num1 + num2;
                double average = (double)sum / 2; 

                Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
                Console.WriteLine($"Average of {num1} and {num2} is: {average}");

                Console.ReadLine();
            }
        }

    }
}
   
