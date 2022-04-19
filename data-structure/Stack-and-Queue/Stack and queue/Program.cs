using System;

namespace Stack_and_queue
{
    //test

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
                throw new Exception("Stack is empty");
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
            if (top == null)
            {
                return true;
                throw new Exception("Stack is empty");
            }
            else
            {
                return false;
            }

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
        public int? Peek()
        {
            if (front != null)
            {
                return front.data;
            }
            else
            {
                Console.WriteLine("Queue is empty");
                return null;

            }
        }

        /// <summary>
        /// Returns true if queue is empty
        /// </summary>
        /// <returns>bool</returns>
        public bool IsEmpty()
        {

            if (front ==null)
            {
                return true;
            }

            return false;
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //stack.Pop();

            //stack.Print();

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Console.WriteLine(queue.Peek()); 


        }
    }
}
