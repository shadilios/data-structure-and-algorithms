using System;

namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

    }


    public class Node
    {
        public Node next;
        public string key;
        public int value;
    }

    public class HashTable
    {
        private readonly Node[] buckets;

        public HashTable(int size)
        {
            buckets = new Node[size];
        }

        public void Add(string key, int item)
        {
            ValidateKey(key);

            var valueNode = new Node() { key = key, value = item, next = null };
            int position = GetBucketByKey(key);

            Node listNode = buckets[position];

            if (listNode == null)
            {
                buckets[position] = valueNode;
            }
            else
            {
                while (listNode.next != null)
                {
                    listNode = listNode.next;
                }
                listNode.next = valueNode;
            }


        }


        public int GetBuckeyByKey(string key)
        {

        }


        public void ValidateKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException(nameof(key));
            }
        }
    }





}
