using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Oğuzhan");
            myDictionary.Add(2, "Aydinay");
            myDictionary.Add(3, "Everything is alright!");

            foreach (var item in myDictionary.GetKeys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myDictionary.GetValues)
            {
                Console.WriteLine(item);
            }


        }
    }
}
