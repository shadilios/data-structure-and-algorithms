using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREE
{
    public class BST : BinrayTree
    {

        public BST()
        {
            Root = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Node current = Root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }

                        else
                        {
                            current = current.right;
                            if (current == null)
                            {
                                parent.right = newNode;
                                break;
                            }
                        }
                    }
                }
            }

        }

        public bool Contains(int data)
        {
            bool output = false;

            if (data == Root.data)
            {
                output = true;
            }

            else if (data > Root.data)
            {
                //search right side
            }

            else if (data < Root.data)
            {
                //search left side
            }

            return output;
        }



    }
}
