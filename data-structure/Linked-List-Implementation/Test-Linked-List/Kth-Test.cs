using System;
using Xunit;
using Linked_List;

namespace Test_Linked_List
{
    public class Kth_Test
    {
        [Fact]
        public void TestKeyIsBiggerThanLength()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            //length = 5
            //0 return value is my error
            Assert.Equal(0, list.Kth(6));
            
        }

        [Fact]
        public void TestKeyIsEqualToLength()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            //length = 5
            //0 return value is my error
            Assert.Equal(0, list.Kth(5));

        }

        [Fact]
        public void TestKeyIsLessThanZero()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            //length = 5
            //0 return value is my error
            Assert.Equal(0, list.Kth(-3));

        }

        [Fact]
        public void TestLengthIsOne()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            

            //length = 1
            //0 return value is my error
            
            Assert.Equal(1, list.Kth(0));

        }

        [Fact]
        public void TestKeyInMiddleOfList()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            //length = 5
            //0 return value is my error
            Assert.Equal(3, list.Kth(2));
        }
    }
}
