﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Node
    {
        public int Value;
        public Node left;
        public Node right;
        public Node(int data)
        {
            Value = data;
            left = null;
            right = null;
        }
    }
}
