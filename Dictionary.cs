using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsDemo
{
    class DictionaryDemo
    {
        public DictionaryDemo()
        {
            Dictionary<string, int> DogTypes = new Dictionary<string, int>();
            {
                DogTypes.Add("Siberian Husky", 1);
                DogTypes.Add("Golden Retriever", 2);
                DogTypes.Add("St.Bernard", 3);
                DogTypes.Add("Great Dane", 4);
            }
            Console.WriteLine("Dictionary example:");
            foreach (KeyValuePair<string, int> kv in DogTypes)
                Console.WriteLine(kv.Value.ToString());
            Console.ReadLine();
            Console.Clear();
        }

    }
}
