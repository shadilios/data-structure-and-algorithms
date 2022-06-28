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
            ht2.Set(2, "Development");
            ht2.Set(3, "Support");




            List<string> x = HashTable.LeftJoin(ht1, ht2);

            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            
        }

       

    }
}
