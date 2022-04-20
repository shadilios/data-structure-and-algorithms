using System;

namespace Stack_Queue_Psuedo
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);

            Console.WriteLine($"Queue Peek: {q.Peek()}");

            Console.WriteLine("*******");

            q.Dequeue();
            Console.WriteLine("Dequeued!");

            Console.WriteLine("*******");


            Console.WriteLine($"Queue Peek: {q.Peek()}");

            Console.WriteLine("*******");


            q.Enqueue(11);
            Console.WriteLine("Enqueued 11");


            Console.WriteLine("*******");

            q.Enqueue(12);
            Console.WriteLine("Enqueued 12");

            Console.WriteLine("*******");

            q.Enqueue(13);
            Console.WriteLine("Enqueued 13");


            Console.WriteLine("*******");


            q.Dequeue();
            Console.WriteLine("Dequeued!");

            Console.WriteLine("*******");

            q.Dequeue();
            Console.WriteLine("Dequeued!");

            Console.WriteLine("*******");


            Console.WriteLine($"Queue Peek: {q.Peek()}");






            //Console.WriteLine(q.Peek());
            //Console.WriteLine(q.Size);

            //q.Dequeue();


            //Console.WriteLine(q.Peek());



        }
    }

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

        public int size;

        /// <summary>
        /// Add data to the stack, data wil be at the bottom
        /// </summary>
        /// <param name="data"></param>
        public void Push(int data)
        {
            Node currentTop = top;

            top = new Node(data);

            top.next = currentTop;

            size++;
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

            size--;
            return data;
        }

        public int Size()
        {
            return size;
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
    }

    public class Queue
    {

        public Stack addingStack;
        public Stack removingStack;
        
        public int Size
        {
            get { return addingStack.size + removingStack.size; }
        }

        public Queue()
        {

            addingStack = new Stack();
            removingStack = new Stack();

        }


        public void Enqueue(int data)
        {
            addingStack.Push(data);
        }

        public int Dequeue()
        {
            MoveToRemoveStack();

            return removingStack.Pop();
        }

        public void MoveToRemoveStack()
        {
            while (addingStack.Size() != 0)
            {
                removingStack.Push(addingStack.Pop());
            }
        }

        public int Peek()
        {
            MoveToRemoveStack();

            return removingStack.Peek();
        }
    }

}
