using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_intersection
{
    internal class Node
    {
        public int value;
        public Node right;
        public Node left;

        public Node(int _value)
        {
            this.value = _value;
            right = null;
            left = null;
        }
    }
}
