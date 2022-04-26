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

    }
}
