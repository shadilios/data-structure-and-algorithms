using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_table
{
    // Key: int
    // Value: string

    public class HashTable
    {
        public int size;

        public Node[] hashTable;


        public HashTable(int hashSize)
        {
            this.size = hashSize;
            hashTable = new Node[hashSize];
        }




        public void Set(int key, string value)
        {
            int index = Hash(key);

            if (hashTable[index] == null)
            {
              hashTable[index] = new Node(key, value);
            }
            else
            {
                Console.WriteLine($"Collision detected at {index}, replacing values");
                hashTable[index].value = value;
            }
        }

        public string Get(int key)
        {
            int index = Hash(key);

            return hashTable[index].value;
        }

        public bool Contains(int key)
        {
            int index = Hash(key);

            if (hashTable[index] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<int>  Keys()
        {
            // loop over array
            // if element is not null, take the key and add it to a list
            // return the list

            List<int> list = new List<int>();

            for (int i = 0; i < hashTable.Length; i++)
            {
                if (hashTable[i] != null)
                {
                    list.Add(hashTable[i].key);
                }
            }

            return list;
        }

        public int Hash(int key)
        {
            // Last step:: % size => so that what ever index I get is within the size of the hash

            return key % size;
        }


        //IT MUST BE STATIC, OR NON STATIC AND DO SOMETHING LIKE ht1.LeftJoin(ht2);
        public static List<string> LeftJoin(HashTable ht1, HashTable ht2)
        {
            List<string> result = new List<string>();

            List<int> listOfKeys = ht1.Keys();
            foreach (int key in listOfKeys)
            {
                string word1 = $"{key}";
                string word2 = "NULL";
                string word3 = "NULL";

                if (ht1.Get(key) != null)
                {
                    word2 = $"{ht1.Get(key)}";
                }
                if (ht2.Contains(key) == true)
                {
                    word3 = $"{ht2.Get(key)}";
                }

                string row = $"{word1}, {word2}, {word3}";

                result.Add(row);
            }
            return result;
        }

    }
}
