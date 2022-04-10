using System;

namespace Stack_and_queue
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

    public class Stack
    {
        public Node top;

        /// <summary>
        /// Add data to the stack, data wil be at the bottom
        /// </summary>
        /// <param name="data"></param>
        public void Push(int data)
        {
            Node currentTop = top;

            top = new Node(data);

            top.next = currentTop;
        }

        /// <summary>
        /// Removes & Returns the top element of the stack
        /// </summary>
        /// <returns>Int</returns>
        public int Pop()
        {
            int data = top.data;

            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                top = top.next;
            }

            return data;
        }


        /// <summary>
        /// Returns the top element of the stack
        /// </summary>
        /// <returns>Int</returns>
        public int Peek()
        {
            return top.data;
        }

        /// <summary>
        /// Returns true if stack is empty
        /// </summary>
        /// <returns>bool</returns>
        public bool IsEmpty()
        {
            bool isEmpty = true;

            if (top != null)
            {
                isEmpty = false;
            }

            return isEmpty;
        }

        /// <summary>
        /// Prints stack with the pointer to its top
        /// </summary>
        public void Print()
        {
            string result = null;
            Node temp = top;

            while (temp != null)
            {
                result += $"->[{temp.data}]";
                temp = temp.next;
            }

            result = $"Top{result}";

            Console.WriteLine(result);
        }
    }

    public class Queue
    {
        public Node front;
        public Node rear;

        //Enqueue: insert element at rear: takes int
        //Peek: check value of front
        //Is empty: returns true if Queue is empty

        public Queue()
        {
            front = null;
            rear = null;
        }

        /// <summary>
        /// Insert element at rear
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (front == null)
            {
                rear = newNode;
                front = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
        }

        /// <summary>
        /// Dequeue: removes the node from the front and return the value: takes null
        /// </summary>
        /// <returns>Int</returns>
        public int Dequeue()
        {
            int result = 0;

            if (front != null)
            {
                if (front.next != null)
                {
                    result = front.data;
                    front = front.next;
                }
                else
                {
                    result = front.data;
                    front = null;
                    rear = null;
                }
            }

            return result;
        }

        /// <summary>
        /// Returns the value of the front node
        /// </summary>
        /// <returns>Int</returns>
        public int Peek()
        {
            int result = 0;

            if (!IsEmpty())
            {
                result = front.data;
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }

            return result;
        }

        /// <summary>
        /// Returns true if queue is empty
        /// </summary>
        /// <returns>bool</returns>
        public bool IsEmpty()
        {
            bool result = false;

            if (rear != null)
            {
                result = true;
            }

            return result;
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.Pop();

            stack.Print();

        }
    }
}
