using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operation equation");
            string equation = Console.ReadLine();

            try
            {
                int result = CalculateEquation(equation);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }

        static int CalculateEquation(string equation)
        {
            equation = equation.Replace(" ", "");

            char[] operators = { '+', '-', '*', '/' };
            int operatorIndex = -1;
            foreach (char op in operators)
            {
                if (equation.Contains(op))
                {
                    operatorIndex = equation.IndexOf(op);
                    break;
                }
            }

            if (operatorIndex == -1)
            {
                throw new ArgumentException("Invalid equation format. Please use one of the operators +, -, *, or /");
            }

            string[] operands = equation.Split(operators, StringSplitOptions.RemoveEmptyEntries);
            if (operands.Length != 2)
            {
                throw new ArgumentException("Invalid equation format. Please provide exactly two operands.");
            }

            int operand1 = int.Parse(operands[0]);
            int operand2 = int.Parse(operands[1]);
            char @operator = equation[operatorIndex];

            switch (@operator)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    if (operand2 == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    return operand1 / operand2;
                default:
                    throw new ArgumentException("Invalid operator. Please use one of the operators +, -, *, or /");
            }
        }
    }
}
