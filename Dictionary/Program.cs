using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();

            myDictionary.Add("Arda");
            myDictionary.Add("Erol");

            MyDictionary<int> myDictionary1 = new MyDictionary<int>();

            myDictionary1.Add(23);

            myDictionary.Add("memleket");
        }
    }
}
