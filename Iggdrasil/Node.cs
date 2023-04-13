using System;
using System.Collections.Generic;
using System.Text;

namespace Iggdrasil
{
    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

}
