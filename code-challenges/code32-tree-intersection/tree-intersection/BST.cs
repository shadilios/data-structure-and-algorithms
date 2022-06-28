using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_intersection
{
    public class BST
    {
        public TreeNode root;
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
                root = new TreeNode(value);
            }
            else
            {
                AddRecursive(root, value);
            }

            count++;
        }

        public void AddRecursive(TreeNode node, int value)
        {
            //Start with the root node
            TreeNode current = root;

            // pointer to store the parent of the current node
            TreeNode parent = null;


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
                parent.left = new TreeNode(value);
            }
            else
            {
                parent.right = new TreeNode(value);
            }

            //return root;
        }

        
    }
}
