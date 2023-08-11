using System;

namespace ITI_day2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of classes: ");
            int numClasses;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numClasses) && numClasses > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number greater than zero.");
                }
            }

            int[][] marksArray = new int[numClasses][];

            for (int i = 0; i < numClasses; i++)
            {
                int numStudents;
                while (true)
                {
                    Console.Write($"Enter the number of students in Class {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out numStudents) && numStudents > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number greater than zero.");
                    }
                }

                marksArray[i] = new int[numStudents];

                for (int j = 0; j < numStudents; j++)
                {
                    while (true)
                    {
                        Console.Write($"Enter marks for Class {i + 1}, Student {j + 1}: ");
                        if (int.TryParse(Console.ReadLine(), out int marks))
                        {
                            marksArray[i][j] = marks;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                }
            }

            double[] averages = new double[numClasses];
            for (int i = 0; i < numClasses; i++)
            {
                int sum = 0;
                for (int j = 0; j < marksArray[i].Length; j++)
                {
                    sum += marksArray[i][j];
                }
                averages[i] = (double)sum / marksArray[i].Length;
            }

            for (int i = 0; i < numClasses; i++)
            {
                Console.WriteLine($"Average marks for Class {i + 1}: {averages[i]:0.00}");
            }

            Console.ReadLine();
        }
    }
}
