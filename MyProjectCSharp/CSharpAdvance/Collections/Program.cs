using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Collections");

            doListDemo();
            doStackDemo();
            doDictionaryDemo();
            doQueueDemo();
            doSetDemo();
        }
        private static void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            //Creating Stack
            Stack<string> stack = new Stack<string>();
            stack.Push("Abhi");
            stack.Push("Rohan");
            stack.Push("Shivam");
            stack.Push("Manoj");
            stack.Push("Mahesh");
            string pop = stack.Pop();

            //Inheriting stack elements
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Popped Element : " + pop);
        }
        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            //Creating List
            List<string> list = new List<string>();
            //Adding object to the list
            list.Add("Karan");
            list.Add("Prafull");
            list.Add("Sandip");
            list.Add("Amol");

            //Inheriting list elements
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

        }
        private static void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doDictionaryDemo");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Aniket");
            dictionary.Add(101, "Sourabh");
            dictionary.Add(102, "Pramod");

            Console.WriteLine("Access value using key(key=100) : " + dictionary[100]);

            Console.WriteLine("\nInheriting Dictionary");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key =" + element.Key + "& Value =" + element.Value);
            }
        }
        private static void doQueueDemo()
        {
            Console.WriteLine("\nIn doQueueDemo");

            //Creating Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Jaikumar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head : " + queue.Peek());
            Console.WriteLine("\nInheriting the queue elements : ");

            //Inheriting Queue elements
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element : " + dequeue);

            Console.WriteLine("\nInheriting the queue elements after dequeue one element :");
            //Inheriting Queue elements using Enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");

            var set = new HashSet<string>();
            set.Add("Akshay");
            set.Add("Shubham");
            set.Add("Prakash");
            set.Add("Ganesh");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
