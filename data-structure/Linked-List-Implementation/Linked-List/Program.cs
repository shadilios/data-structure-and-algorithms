using System;

namespace Linked_List
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    public class LinkedList
    {

        public Node headNode;



        #region Code Challenge 05 Part

        //code challenge05 functions:
        // 1- add new node to head of list (Insert)
        // 2- check if value exists in list (Includes)
        // 3- print list (ToString)

        //Insert an element to the beginning of the list
        public void Insert(int data)
        {
            Node node = new Node(data);
            node.next = headNode;
            headNode = node;
        }
        
        //Search for a value in the list
        public bool Includes(int dataToSearch)
        {
            Node temp = headNode;

            while (temp != null)
            {
                if (temp.data == dataToSearch)
                {
                    return true;
                }
                temp = temp.next;
            }

            return false;
        }

        public string ConvertToString()
        {
            string result = null;
            Node temp = headNode;

            while (temp != null)
            {
                result += $"[{temp.data}]->";
                temp = temp.next;
            }

            result = $"{result}null";
            return result;
        }
        #endregion


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(0);
            list.Insert(1);
            list.Insert(2);

            Console.WriteLine(list.ConvertToString());
        }
    }
}
