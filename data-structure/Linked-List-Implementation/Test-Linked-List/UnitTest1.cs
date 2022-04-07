using System;
using Xunit;
using Linked_List;

namespace Test_Linked_List
{
    public class UnitTest1
    {
        #region Code Challenge 05 Tests

        //1- Can instantiate empty object
        [Fact]
        public void CanInstantiate()
        {
            LinkedList list = new LinkedList();

            Assert.NotNull(list);
        }

        //2- Can insert into the linked list
        [Fact]
        public void CanInsert()
        {
            LinkedList list = new LinkedList();

            list.Insert(5);

            Assert.Equal(5, list.headNode.data);
        }

        //3- The head property will properly point to the first node in the linked list
        [Fact]
        public void HeadPointsToFirstNode()
        {
            LinkedList list = new LinkedList();

            list.Insert(7);
            list.Insert(5);
            list.Insert(10);

            Assert.Equal(10, list.headNode.data);

        }

        //4- Can properly insert multiple nodes into the linked list
        [Fact]
        public void CanInsertMultiple()
        {
            LinkedList list = new LinkedList();

            list.Insert(7);
            list.Insert(5);
            list.Insert(10);

            Assert.Equal(10, list.headNode.data);
            Assert.Equal(5, list.headNode.next.data);
            Assert.Equal(7, list.headNode.next.next.data);


        }



        //5- Will return true when finding a value within the linked list that exists
        [Fact]
        public void CanSearchTrue()
        {
            LinkedList list = new LinkedList();

            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Insert(8);
            list.Insert(9);

            Assert.True(list.Includes(7));

        }

        //6- Will return false when searching for a value in the linked list that does not exist
        [Fact]
        public void CanSearchFalse()
        {
            LinkedList list = new LinkedList();

            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Insert(8);
            list.Insert(9);

            Assert.False(list.Includes(321561));
        }

        //7- Can properly return a collection of all the values that exist in the linked list

        [Fact]
        public void CanReturnAllValues()
        {
            LinkedList list = new LinkedList();

            list.Insert(3);
            list.Insert(2);
            list.Insert(1);

            Assert.Equal("[1]->[2]->[3]->null",list.ConvertToString());

        }


        #endregion

    }
}
