using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsDemo
{
    class QueueDemo
    {
        public QueueDemo()
        {
            Queue<string> fruit = new Queue<string>();
            fruit.Enqueue("Apples");
            fruit.Enqueue("Oranges");
            fruit.Enqueue("Cherries");
            fruit.Enqueue("Mango");
            fruit.Enqueue("Bananas");
            Console.WriteLine("Queue example:");
            foreach (Object obj in fruit)
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
