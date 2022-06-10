using System;

namespace hash_table
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTable ht = new HashTable(1024);

            ht.Set(0, "Shadi");
            ht.Set(1, "Osama");
            ht.Set(2, "Zaid");
            ht.Set(3, "Ahmad");
            ht.Set(4, "Laith");


            Console.WriteLine(ht.Get(2)); 

        }
    }

}
