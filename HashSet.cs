using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsDemo
{
    class HashSetDemo
    {
        public HashSetDemo()
        {
            HashSet<string> names = new HashSet<string>(new string[] { "Tom", "Sarah", "Rick", "William", "Amanda" });
            HashSet<int> ages = new HashSet<int>(new int[] { 21, 24, 25, 27, 26 });
            Console.WriteLine("HashSet example:");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
