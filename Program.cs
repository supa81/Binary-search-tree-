using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch numbers = new BinarySearch();
            numbers.AddNewNode(new Node(81));
            numbers.AddNewNode(new Node(23));
            numbers.AddNewNode(new Node(34));
            numbers.AddNewNode(new Node(48));
            numbers.AddNewNode(new Node(05));

            // make sure nodes are being added through debugging over numbers making a tree 
        }
    }
}
