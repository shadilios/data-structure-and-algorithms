﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREE
{
    public class Node
    {
        public int data;

        public Node left;

        public Node right;

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }

    }
}
