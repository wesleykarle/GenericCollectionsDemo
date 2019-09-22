using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollectionsDemo
{
    class LinkedListDemo
    {
        public LinkedListDemo()
        {
            LinkedList<int> FootballScore = new LinkedList<int>();

            FootballScore.AddLast(21);
            FootballScore.AddFirst(14);
            FootballScore.AddLast(28);
            FootballScore.AddFirst(7);

            Console.WriteLine("LinkedList example:");
            foreach (var item in FootballScore)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();

        }
    }
}
