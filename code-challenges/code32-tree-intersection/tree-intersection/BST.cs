using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_intersection
{
    internal class BST
    {
        public Node root;
        public int count;
        public BST()
        {
            root = null;
            count = 0;
        }

        public void Add(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                AddRecursive(root, value);
            }

            count++;
        }

        public void AddRecursive(Node node, int value)
        {
            //Start with the root node
            Node current = root;

            // pointer to store the parent of the current node
            Node parent = null;


            //if (root == null)
            //{
            //    return new Node(value);
            //}



            while (current != null)
            {
                parent = current;

                if(value < current.value)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }

            if(value < parent.value)
            {
                parent.left = new Node(value);
            }
            else
            {
                parent.right = new Node(value);
            }

            //return root;
        }

        
    }
}
