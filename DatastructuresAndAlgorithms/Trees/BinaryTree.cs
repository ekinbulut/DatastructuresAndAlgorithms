using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresAndAlgorithms.Trees
{
     public class TreeNode
    {
        internal int data;
        internal TreeNode leftChild;
        internal TreeNode rightChild;

    }
    public class BinaryTree
    {
        TreeNode root;

        public void InsertData(int data)
        {
            TreeNode tempNode = new TreeNode();
            TreeNode current = new TreeNode();
            TreeNode parent = new TreeNode();

            tempNode.data = data;
            tempNode.leftChild = null;
            tempNode.rightChild = null;

            if (root == null)
            {
                root = tempNode;
                return;
            }
            else
            {
                current = root;
                parent = null;
            }

            while (true)
            {
                parent = current;

                if (data < parent.data)
                {
                    current = current.leftChild;

                    if (current == null)
                    {
                        parent.leftChild = tempNode;
                        return;
                    }
                }
                else
                {
                    current = current.rightChild;

                    if (current == null)
                    {
                        parent.rightChild = tempNode;
                        return;
                    }
                }
            }
        }

        public TreeNode SearchNode(int data)
        {
            TreeNode current = root;

            while (current.data != data)
            {
                if (current != null)
                {
                    Console.WriteLine("Current Data : " + current.data);
                }

                if (current.data > data)
                {
                    current = current.leftChild;
                }
                else
                {
                    current = current.rightChild;
                }

                if (current == null)
                {
                    return null;
                }
            }

            return current;
        }
    }
}
