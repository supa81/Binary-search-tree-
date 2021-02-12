using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinarySearch
    {
        public Node root;

        public BinarySearch()
        {
            root = null;
        }
        public void AddNewNode(int s)
        {
            Node nodeToAdd = new Node(s);
            if (root == null)
            {
                root = nodeToAdd;
            }
            Node current = root;
            while (true)
            {
                if (current.data > nodeToAdd.data)
                {


                    if (current.left == null)
                    {
                        current.left = nodeToAdd;
                    }
                    else
                    {
                        current = current.left;
                    }
                }
                else
                {
                    if (current.data < nodeToAdd.data)
                    {
                        if (current.right == null)
                        {
                            current.right = nodeToAdd;
                        }
                        else
                        {
                            current = current.right;
                        }

                    }
                }
            }
             
        }
        public void Search()
        {
            Node node;
           
            if ( )
            {

            }

        }

    }
}

