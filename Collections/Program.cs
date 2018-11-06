using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //A(5.0);
            //A(5.0f);
            A(5);
            //var list = new List<int>();
            //list.Add(5);
            //list.Add(7);
            //for (int i = 0; i < 5; i++)
            //{
            //    list.Add(i);
            //}

            //list[0] = 3;

            //Show(list);

            //list.Remove(3);

            //var floatList = new List<float>();
            //for (int j = 0; j < 5; j++)
            //{
            //    floatList.Add(j);
            //}

            //Show(list);
            //Show(floatList);

            //// 3 7 0 1 2 3 4

            //list.RemoveAll(Check);

            //list.RemoveAll(i => Check(i));

            //list.RemoveAll(i => i % 2 == 0);

            //list.RemoveAll(i =>
            //{
            //    return i % 2 == 0;
            //});





            Console.Read();









        }

        static bool Check(int i)
        {
            return i % 2 == 0;
        }

        static bool Check<T>(T item)
        {
            return item != null;
        }

        static void Show<T>(List<T> theList)
        {
            foreach (T item in theList)
            {
                Console.Write(item + " ");
            }
        }


        static void A(double a)
        { }

        static void A(float a)
        { }

        
    }
}
