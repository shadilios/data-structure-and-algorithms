using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREE
{
    public class BinrayTree
    {
        public Node Root { get; set; }


        //  root -> left -> right
        public void PreOrder(Node rootNode)
        {
            Console.Write(rootNode.data + " ->");

            if (rootNode.left != null)
            {
                PreOrder(rootNode.left);
            }
            if (rootNode.right != null)
            {
                PreOrder(rootNode.right);
            }
        }

        //  left -> root -> right
        public void InOrder(Node rootNode)
        {

            if (Root.left != null)
            {
                PreOrder(Root.left);
            }

            Console.Write(rootNode.data + " ->");


            if (Root.right != null)
            {
                PreOrder(Root.right);
            }
        }

        //  returns an array of ordered values
        //  left -> right -> root
        public void PostOrder(Node rootNode)
        {

            if (Root.left != null)
            {
                PreOrder(Root.left);
            }
            if (Root.right != null)
            {
                PreOrder(Root.right);
            }

            Console.Write(rootNode.data + " ->");

        }



        public int? Max()
        {
            int? output = null;
            /*
             * Check if Tree is null, if yes return error it's empty
             * Save root value, compare it to left & right
             * compare each left and right to its each left & right
            */

           // Traverse whole tree, save max value, if while traversing I find a higher value, that's my new high value, if Not, I keep my old value

            // If this was binary tree, go directly to value of  leaf after Root.right.right.right * h ...etc


            return output;
        }





    }
}
