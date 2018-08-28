using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresAndAlgorithms.LinkLists
{
    public class LinkNode
    {
        internal int data;
        internal int key;
        internal LinkNode next;
    }

    public class CustomLinkedList
    {
        LinkNode head = null;
        LinkNode current = null;


        public void InsertFirst(int key, int data)
        {
            LinkNode link = new LinkNode();

            link.key = key;
            link.data = data;

            link.next = head; // previous node

            head = link;
        }

        public void Print()
        {
            LinkNode node = head;

            while (node != null)
            {
                Console.Write($"( {node.key} , { node.data } ) --> ");

                node = node.next;
            }
            Console.WriteLine("");

        }

        public LinkNode Find(int key)
        {
            LinkNode current = head;

            while (current.next != null)
            {
                if (current.key == key)
                {
                    return current;
                }

                current = current.next;
            }

            return null;

        }

        public void Delete(int key)
        {
            LinkNode current = head;
            LinkNode temp = null;

            while (current.key != key)
            {

                if (current.next == null)
                {
                    return;
                }
                else
                {
                    temp = current;
                    current = current.next;
                }
            }

            if (current == head)
            {
                head = head.next;
            }
            else
            {
                temp.next = current.next;
            }


        }
    }
}
