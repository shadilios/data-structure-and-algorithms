using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace hash_table
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTable ht1 = new HashTable(1024);

            ht1.Set(0, "Shadi");
            ht1.Set(1, "Osama");
            ht1.Set(2, "Zaid");
            ht1.Set(3, "Ahmad");
            ht1.Set(4, "Laith");

            HashTable ht2 = new HashTable(1024);

            ht2.Set(0, "Engineer");
            ht2.Set(1, "Marketing");
            ht2.Set(2, "Developer");
            ht2.Set(3, "Support");
            ht2.Set(4, "Something");




            Console.WriteLine(ht1.Get(2));

            LeftJoin(ht1, ht2);
        }

        public static void LeftJoin(HashTable left, HashTable right)
        {
            // Combine the key and corresponding values (if they exist) into a new data structure according to LEFT JOIN logic.
            // LEFT JOIN means all the values in the first hashmap are returned, and if values exist in the “right” hashmap, they are appended to the result row.
            // If no values exist in the right hashmap, then some flavor of NULL should be appended to the result row.

            // This will Hold both of my tables joined together
            List<string[]> arrayList = new List<string[]>();

            for (int i = 0; i < left.hashTable.Length; i++)
            {
                string[] array = new string[3];

                string word1 = Convert.ToString(i);
                string word2 = left.Get(i);
                string word3 = right.Get(i);

                arrayList.Insert(i, array);
            }
        }

    }
}
