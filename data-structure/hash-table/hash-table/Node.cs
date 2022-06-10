using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_table
{
    public class Node
    {
        public int key;

        public string value;

        public Node(int key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
