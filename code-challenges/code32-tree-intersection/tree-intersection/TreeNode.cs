using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_intersection
{
    public class TreeNode
    {
        public int value;
        public TreeNode right;
        public TreeNode left;

        public TreeNode(int _value)
        {
            this.value = _value;
            right = null;
            left = null;
        }
    }
}
