using System;
using Xunit;
using tree_intersection;
using System.Collections.Generic;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ExpectedOutcomt()
        {
            BST bst = new BST();
            bst.Add(8);
            bst.Add(3);
            bst.Add(1);
            bst.Add(6);

            BST bst2 = new BST();
            bst2.Add(9);
            bst2.Add(3);
            bst2.Add(1);
            bst2.Add(6);

            List<int> x = TreeIntersection.TreesIntersection(bst, bst2);
            List<int> y = new List<int> { 1, 6, 3 };

            Assert.Equal(x, y);
        }


        [Fact]
        public void ExpectedFailure()
        {
            BST bst = new BST();
            bst.Add(8);
            bst.Add(3);
            bst.Add(1);
            bst.Add(6);

            BST bst2 = new BST();
            bst2.Add(9);
            bst2.Add(3);
            bst2.Add(1);
            bst2.Add(6);

            List<int> x = TreeIntersection.TreesIntersection(bst, bst2);
            List<int> y = new List<int> { 9, 9 };

            Assert.NotEqual(x, y);
        }

    }
}
