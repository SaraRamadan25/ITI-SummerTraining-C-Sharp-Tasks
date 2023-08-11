using System;
using System.Collections.Generic;

namespace GenericStackExample
{
    class Stack<T>
    {
        private List<T> items = new List<T>();

        public int Count
        {
            get { return items.Count; }
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("The stack is empty");

            T item = items[Count - 1];
            items.RemoveAt(Count - 1);
            return item;
        }

       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);


            int poppedItem = intStack.Pop();
            Console.WriteLine("Popped item: " + poppedItem); 

            Console.ReadLine();
        }
    }
}
