using System;
using Xunit;
using Stack_Queue_Psuedo;

namespace Test_Psuedo_Queue
{
    public class UnitTest1
    { 
        [Fact]
        public void TestEnqueue()
        {

            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            //Test if size is correct
            Assert.Equal(3, q.Size);

            //Test if enqueue is adding in the right position
            Assert.Equal(3, q.addingStack.top.data);
            
        }


        [Fact]
        public void TestDequeue()
        {
            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            q.Dequeue();



            //Test if size is correct after dequeue
            Assert.Equal(3, q.Size);

            //Test if dequeue is working as intended
            Assert.Equal(2, q.removingStack.top.data);
        }

        [Fact]
        public void TestPeek()
        {
            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            //If this doesn't equal one, that means that the functionality in my second stack isn't right
            Assert.Equal(1, q.Peek());
        }
        


    }
}
