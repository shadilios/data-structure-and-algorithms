using System;
using Xunit;
using Linked_List;

namespace Test_Linked_List
{
    public class Insertions_Test 
    {
        //Can successfully add a node to the end of the linked list
        [Fact]
        public void CanAppend()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);

            Assert.Equal(2, list.headNode.next.data);
        }

        //Can successfully add multiple nodes to the end of a linked list
        [Fact]
        public void CanAppendMultiple()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);

            Assert.Equal(2, list.headNode.next.data);
            Assert.Equal(3, list.headNode.next.next.data);
            Assert.Equal(4, list.headNode.next.next.next.data);

        }

        //Can successfully insert a node before a node located i the middle of a linked list
        [Fact]
        public void CanInsertBeforeMiddle()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);

            list.InsertBefore(2, 99);       //add 99 before the value 2

            Assert.Equal(99, list.headNode.next.data);
        }

        //Can successfully insert a node before the first node of a linked list
        [Fact]
        public void CanInsertBeforeFirst()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);

            list.InsertBefore(1, 99);

            Assert.Equal(99, list.headNode.data);
        }

        //Can successfully insert after a node in the middle of the linked list
        [Fact]
        public void CanInsertAfterMiddle()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);

            list.InsertAfter(2, 99);

            Assert.Equal(99, list.headNode.next.next.data);
        }


        //Can successfully insert a node after the last node of the linked list
        [Fact]
        public void CanInsertAfterFinal()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);

            list.InsertAfter(3, 99);

            Assert.Equal(99, list.headNode.next.next.next.data);
        }
    }
}
