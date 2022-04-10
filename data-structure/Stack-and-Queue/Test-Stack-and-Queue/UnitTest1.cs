using System;
using Xunit;
using Stack_and_queue;

namespace Test_Stack_and_Queue
{
    public class UnitTest1
    {
        /*
        rest to do:
        Calling pop or peek on empty stack raises exception
        Can successfully enqueue into a queue
        Can successfully enqueue multiple values into a queue
        Can successfully dequeue out of a queue the expected value
        Can successfully peek into a queue, seeing the expected value
        Can successfully empty a queue after multiple dequeues
        Can successfully instantiate an empty queue
        Calling dequeue or peek on empty queue raises exception
        */

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


    }
}
