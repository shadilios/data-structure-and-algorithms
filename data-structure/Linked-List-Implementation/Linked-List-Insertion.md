[Main Readme File](https://github.com/shadilios/data-structure-and-algorithms)

# Challenge Summary

Write 3 functions that handles Insertion functionalities of a linked list:  
1. Append: (Adds a new node at the end of the list).
2. InsertBefore: (Adds a new node before a specific node).
3. InsertAfter: (Adds a new node after a specific node).

## Whiteboard Process

![Linked_List_Insertion](https://user-images.githubusercontent.com/70282602/162588316-9b7033e8-202d-429a-a87b-18f387a653d3.png)

## Approach & Efficiency

Big O(n) for space because I use awhile loop to iterate through my list. 
O(1) for time because I edit the same list.

## Solution



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

        

