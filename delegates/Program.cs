using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        delegate bool ComparisonDelegate(int a, int b);

        static void Main(string[] args)
        {
            int[] array = { 3, 5, 7, 14, 18 };

            BubbleSort(array, CompareAscending);
            Console.WriteLine("Sorted in ascending order:");
            PriArray(array);

            BubbleSort(array, CompareDescending);
            Console.WriteLine("Sorted in descending order:");
            PriArray(array);

            Console.ReadLine();
        }

        static void BubbleSort(int[] arr, ComparisonDelegate comparison)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (comparison(arr[j], arr[j + 1]))
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static bool CompareAscending(int a, int b)
        {
            return a > b;
        }

        static bool CompareDescending(int a, int b)
        {
            return a < b;
        }

        static void PriArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
