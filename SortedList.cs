using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollectionsDemo
{
    class SortedListDemo
    {
        public SortedListDemo()
        {
            SortedList numbers = new SortedList();

            numbers.Add("15", 15);
            numbers.Add("14", 14);
            numbers.Add("13", 13);
            numbers.Add("12", 12);
            numbers.Add("11", 11);
            numbers.Add("10", 10);
            Console.WriteLine("SortedList example:");
            foreach (DictionaryEntry pair in numbers)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
