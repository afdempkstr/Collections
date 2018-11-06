using System;
using System.Linq;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
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

            var even = list.Where(i => i % 2 == 0).Reverse();

            foreach (var i in even)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();

            var dict = new Dictionary<string, int>();

            dict.Add("kostas", 2105555555);
            dict.Add("george", 2109999999);

            dict.ContainsKey("test");

            dict["nick"] = 697123123;

            dict["nick"] = 333;

            foreach (var item in dict)
            {
                Console.Write($"{item.Key} => {item.Value} ");
            }

            var s = dict["george"];

            Console.WriteLine();

            dict.Add("gianna", 2004);
            dict.Add("gus", 35423423);

            var q = from item in dict
                    where item.Key.StartsWith("g")
                    orderby item.Key
                    select item;

            foreach (var qq in q)
            {
                Console.Write($"{qq.Key} => {qq.Value} ");
            }

            Console.WriteLine();

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

        static void Increment(int x)
        {
            x = x + 1;
        }

        static void IncByRef(ref int x)
        {
            x = x + 1;
        }

        static IEnumerable<int> Iterator(int count)
        {
            int i = 0;
            while (i < count)
            {
                yield return i++;
            }
            yield break;
        }

    }
}
