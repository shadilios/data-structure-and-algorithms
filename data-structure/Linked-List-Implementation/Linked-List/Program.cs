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

        #region Code Challenge 06 Part

        /// <summary>
        /// Add new node that contains the data at the end of list
        /// </summary>
        /// <param name="data"></param>
        public void Append(int data)
        {
            //if first element is empty
            if (headNode == null)
            {
                Node newNode = new Node(data);
                newNode.next = headNode;
                headNode = newNode;
            }
            else
            {
                Node temp = headNode;

                while (temp.next != null)
                {
                    temp = temp.next;
                }

                Node newNode = new Node(data);
                temp.next = newNode;
            }




            
        }

        /// <summary>
        /// Inserts a new node containing the data before the searchValue
        /// </summary>
        /// <param name="searchValue"></param>
        /// <param name="data"></param>
        public void InsertBefore(int searchValue, int data)
        {
            Node newNode = new Node(data);

            if (headNode == null)
            {
                Console.WriteLine("Error: This list is empty!");
            }
            else if (Includes(searchValue) == false)
            {
                Console.WriteLine("Error: List doesn't contain the value you're searching for!");
            }
            else if(headNode.data == searchValue)
            {
                Insert(data);
            }
            else
            {
                Node temp = headNode;
                while (temp.next != null)
                {
                    Console.WriteLine(temp.next.data);
                    if (temp.next.data == searchValue)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                    }

                    temp = temp.next;
                }
            }

        }


        /// <summary>
        /// Inserts a new node containing the data after the searchValue
        /// </summary>
        /// <param name="searchValue"></param>
        /// <param name="data"></param>
        public void InsertAfter(int searchValue, int data)
        {
            Node newNode = new Node(data);

            if (headNode == null)
            {
                Console.WriteLine("Error: This list is empty!");
            }
            else if (Includes(searchValue) == false)
            {
                Console.WriteLine("Error: List doesn't contain the value you're searching for!");
            }
            else if (headNode.data == searchValue)
            {
                if (headNode.next == null)
                {
                    Append(data);
                }
                else
                {
                    newNode.next = headNode.next;
                    headNode.next = newNode;
                }
            }
            else
            {
                Node temp = headNode;
                while (temp.next != null)
                {
                    Console.WriteLine(temp.next.data);
                    if (temp.next.data == searchValue)
                    {
                        newNode.next = temp.next.next;
                        temp.next.next = newNode;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        #endregion


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            //list.InsertBefore(5, 10);
            list.InsertAfter(1, 10);
            list.InsertAfter(2, 10);
            list.InsertAfter(3, 10);
            list.InsertAfter(4, 10);
            list.InsertAfter(5, 10);

            Console.WriteLine(list.ConvertToString());
        }
    }
}
