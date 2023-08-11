using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_day2_1._1
{
    class Program
    {
        static void Main(string[] args)
    {
            Console.WriteLine("Enter the number of integers:");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (int num in numbers)
            {
                sum += num;
                max = Math.Max(max, num);
                min = Math.Min(min, num);
            }

            double average = (double)sum / count;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.ReadKey();
           

}
    }
}
