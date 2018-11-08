using System;
using System.Linq;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // call the iterator and loop over the results
            foreach (int current in Iterator(5))
            {
                Console.WriteLine(current);
            }

            var list = new List<int>();
            list.AddRange(Enumerable.Range(0, 10));

            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // the iteration does not modify the list
            Show(list);
            Console.WriteLine();

            // find all even numbers in the list and reverse their order
            var even = list.Where(i => i % 2 == 0).Reverse();

            foreach (var i in even)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // these operations do not modify the initial list
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // A dictionay maps a key to a value. Supports fast lookups by key.
            var dict = new Dictionary<string, int>();
            dict.Add("kostas", 2105555555);
            dict.Add("george", 2109999999);

            // get an existing value by key
            var georgePhone = dict["george"];

            // Check if a a value is associated with a key in the dictionary
            bool exists = dict.ContainsKey("test");

            dict["nick"] = 697123123; // this associates a new value with the given key

            dict.Add("gus", 35423423);
            dict.Add("gianna", 2004);
            dict["nick"] = 333; // this will update the existing value

            // when enumerating the contents of a dictionary they may not be returned
            // in the same order as the one they were added
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            // old-style linq: find all items whose key starts with the letter g
            var q = from item in dict
                    where item.Key.StartsWith("g")
                    orderby item.Key
                    select item;

            foreach (var qq in q)
            {
                Console.Write($"{qq.Key} => {qq.Value} ");
            }
            Console.WriteLine();
            
            // the same using lambda expressions
            var q2 = dict
                .Where(item => item.Key.StartsWith("g"))
                .OrderBy(item => item.Key)
                .Select(item => item);

            foreach (var qq in q2)
            {
                Console.Write($"{qq.Key} => {qq.Value} ");
            }

            Console.Read();
        }

        static void Show<T>(List<T> theList)
        {
            foreach (T item in theList)
            {
                Console.Write(item + " ");
            }
        }

        // passing arguments by value
        static void Increment(int x)
        {
            x = x + 1;
        }

        // passing arguments by reference
        static void IncByRef(ref int x)
        {
            x = x + 1;
        }

        static void OutParam(int input, out int x)
        {
            // out parameters need to be initialized with a value within the method
            x = input + 1;
        }

        static IEnumerable<int> Iterator(int count)
        {
            int i = 0;
            while (i < count)
            {
                yield return i++;
                // when the execution continues for the next iteration, this
                //is the next line to be executed
            }
            //this causes the iteration to stop
            yield break;
        }

    }
}
