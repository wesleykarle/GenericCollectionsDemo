using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollectionsDemo
{
    class StackDemo
    {
        public StackDemo()
        {
            Stack greeting = new Stack();
            greeting.Push(" Wes!");
            greeting.Push(" is");
            greeting.Push(" name");
            greeting.Push(" my");
            greeting.Push("Hello,");

            Console.WriteLine("Stack example:");

            foreach (var itm in greeting)
                Console.Write(itm);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
