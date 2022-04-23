using System;
using Xunit;
using Stack_and_queue;

namespace Test_Stack_and_Queue
{
    public class UnitTest1
    {
        

        //test

        [Fact]
        public void CanPushStack()
        {
            Stack stack = new Stack();
            stack.Push(1);

            Assert.Equal(1, stack.top.data);

        }

        [Fact]
        public void CanPushStackMultiple()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);


            Assert.Equal(1, stack.top.next.data);
        }

        [Fact]
        public void CanPopStack()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.Equal(1, stack.top.data);
        }

        [Fact]
        public void CanEmptyStack()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);

            stack.Pop();
            stack.Pop();

            Assert.Null(stack.top);
        }

        [Fact]
        public void CanPeekNext()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.Equal(1, stack.Peek());
        }

        [Fact]
        public void CanInstantiateEmptyStack()
        {
            Stack stack = new Stack();

            Assert.Null(stack.top);
        }


        [Fact]
        public void CanEnqueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(1);

            Assert.Equal(1, queue.front.data);

        }

        [Fact]
        public void CanEnqueueMultiple()
        {
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.Equal(1, queue.front.data);
            Assert.Equal(3, queue.rear.data);

        }

        [Fact]
        public void CanDequeue()
        {
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.Equal(1, queue.Dequeue());
            Assert.Equal(2, queue.Dequeue());
            Assert.Equal(3, queue.Dequeue());

        }

        [Fact]
        public void CanPeekQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.Equal(1, queue.Peek());
        }

        [Fact]
        public void CanEmptyQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.Null(queue.front);
        }

        [Fact]
        public void CanInstantiateEmptyQueue()
        {
            Queue queue = new Queue();

            Assert.Null(queue.front);   
        }


    }
}
