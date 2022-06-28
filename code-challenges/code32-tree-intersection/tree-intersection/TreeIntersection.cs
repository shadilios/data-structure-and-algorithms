using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_intersection
{
    public class TreeIntersection
    {
        static public HashTable hashTableINS = new HashTable(100);

        static public List<int> result = new List<int>();

        public static List<int> TreesIntersection(BST x, BST y)
        {
            HashTableInsert(x.root);
            HashTableContains(y.root);

            return result;
        }

        public static void HashTableInsert(TreeNode root)
        {
            if (root.left != null)
            {
                HashTableInsert(root.left);
            }
            if (root.right != null)
            {
                HashTableInsert(root.right);
            }

            hashTableINS.Set(root.value, root.value.ToString());
        }

        public static void HashTableContains(TreeNode root)
        {
            if (root.left != null)
            {
                HashTableContains(root.left);
            }
            if (root.right != null)
            {
                HashTableContains(root.right);
            }
            if (hashTableINS.Contains(root.value))
            {
                result.Add(root.value);
            }
        }

        
    }
}
