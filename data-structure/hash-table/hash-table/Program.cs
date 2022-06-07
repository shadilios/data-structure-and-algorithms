using System;

namespace hash_table
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTable<int> ht = new HashTable<int>(10);
            ht.Put(1, 2);
            ht.Put(2, 3);
            ht.Put(3, 4);
            ht.Put(4, 5);
            ht.Put(5, 6);
            ht.Put(6, 7);
            ht.Put(7, 8);
            ht.Put(8, 9);
            ht.Put(9, 10);
            ht.Put(10, 11);
            ht.Put(11, 12);
        }
    }

    public class Node
    {
        public int key;
        public Object value;
        public Node next;

        public Node(int key, object value)
        {
            this.key = key;
            this.value = value;
            next = null;
        }

        public int GetKey()
        {
            return key;
        }

        public object GetValue()
        {
            return value;
        }
    }

    public class HashTable<T>
    {
        public Node[] hashArray;

        public int size;

        public HashTable(int size)
        {
            this.size = size;
            hashArray = new Node[size];
        }

        public int GetHash(int key)
        {
            return key % size;
        }

        public void Put(int key, object value)
        {
            int hashIndex = GetHash(key);
            Node arrayValue = hashArray[hashIndex];
            Node newItem = new Node(key, value);

            newItem.next = arrayValue.next;
            arrayValue.next = newItem;
        }

        public T Get(int key)
        {
            T value = null;
            int hashIndex = GetHash(key);

            Node arrayValue = hashArray[hashIndex];

            while (arrayValue != null)
            {
                if (arrayValue.GetKey() == key)
                {
                    value = (T)arrayValue.GetValue();
                    break;
                }
                arrayValue = arrayValue.next;
            }

            return value;
        }
    }
}
