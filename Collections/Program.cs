using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
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

            int testValue;
            bool exists = dict.TryGetValue("test", out testValue);
            testValue = 3;


            var badIdea = new Dictionary<object, object>();
            var goodOldDays = new System.Collections.Hashtable();

            int a = 5;
            Increment(a);
            Console.WriteLine(a);
            IncByRef(ref a);
            Console.WriteLine(a);


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

    }
}
