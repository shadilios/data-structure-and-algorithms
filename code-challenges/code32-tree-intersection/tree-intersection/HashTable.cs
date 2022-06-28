﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_intersection
{
     public class HashTable
    {
        public int size;

        public HashNode[] hashTable;


        public HashTable(int hashSize)
        {
            this.size = hashSize;
            hashTable = new HashNode[hashSize];
        }




        public void Set(int key, string value)
        {
            int index = Hash(key);

            if (hashTable[index] == null)
            {
                hashTable[index] = new HashNode(key, value);
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


        public List<int> Keys()
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

    }
}
