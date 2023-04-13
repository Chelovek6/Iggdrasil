using System;
using System.Collections.Generic;
using System.Text;

namespace Iggdrasil
{
    class Derevo
    {
        public Node root;

        //public Derevo() => public Node root;
            
        
    
        public Derevo()
        {
            root = null;
        }

        public void Add(int data)
        {
            root = AddRecursive(root, data);
        }

        private Node AddRecursive(Node current, int data)
        {
            if (current == null)
            {
                return new Node(data);
            }

            if (data < current.Data)
            {
                current.Left = AddRecursive(current.Left, data);
            }
            else if (data > current.Data)
            {
                current.Right = AddRecursive(current.Right, data);
            }

            return current;
        }

        public bool Search(int data)
        {
            return SearchRecursive(root, data);
        }

        private bool SearchRecursive(Node current, int data)
        {
            if (current == null)
            {
                return false;
            }

            if (data == current.Data)
            {
                return true;
            }

            return data < current.Data
              ? SearchRecursive(current.Left, data)
              : SearchRecursive(current.Right, data);
        }
    }
}




