using System;
using System.Collections.Generic;

namespace MyQueue
{
    class MyQueue
    {
        private List<int> items;

        public MyQueue()
        {
            items = new List<int>();
        }

        public void Enqueue(int n)
        {
            items.Add(n);
        }

        public int Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            int firstItem = items[0];
            items.RemoveAt(0);
            return firstItem;
        }

        public int Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return items[0];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyQueue q = new MyQueue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            Console.WriteLine(q.Peek());    // should output 1
            Console.WriteLine(q.Dequeue()); // should output 1
            Console.WriteLine(q.Dequeue()); // should output 2
            Console.WriteLine(q.Dequeue()); // should output 3
            // Console.WriteLine(q.Dequeue()); // should throw InvalidOperationException
        }
    }
}
