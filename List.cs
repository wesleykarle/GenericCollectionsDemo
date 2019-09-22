using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsDemo
{
    class ListDemo
    {
        public ListDemo()
        {
            List<string> DaysOfTheWeek = new List<string>()
            {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine("List example:");
            foreach (string i in DaysOfTheWeek)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
