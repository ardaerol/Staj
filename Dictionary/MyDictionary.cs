using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary <T>
    {
        T[] tempArray;
        T[] items;

        public MyDictionary()
        {
            tempArray = new T[0];
            items = new T[0];

        }

        public void Add(T item)
        {
            tempArray=items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
            Console.WriteLine(item);
        }
    }
}
