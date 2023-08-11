using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                long result = CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is: {result}");
                Console.ReadLine();
            }
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
    }
}
