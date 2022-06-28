using System;
using System.Collections.Generic;

namespace tree_intersection
{
    public class Program
    {
        public static void Main(string[] args)
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


            foreach (var item in x)
            {
                Console.WriteLine(item);
            }



        }
    }
}
