using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Read();






        }

        static void Show<T>(List<T> theList)
        {
            foreach (T item in theList)
            {
                Console.Write(item + " ");
            }
        }

    }
}
