using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 54, 21, 7, 57, 69, 90, 97, 80, 34 };


            //var result = Algorithm.InsertionSort(arr);
            //var result = Algorithm.SelectionSort(arr);
            //var result = Algorithm.BubbleSort(arr);

            var result = Algorithm.MergeSort(arr);

            Console.WriteLine("Result : " + String.Join<int>(" ",arr));


            var binarytree = Datastructures.GetBinaryTree();
            
            binarytree.InsertData(5);
            binarytree.InsertData(10);
            binarytree.InsertData(23);
            binarytree.InsertData(3);
            binarytree.InsertData(2);
            binarytree.InsertData(4);
            binarytree.InsertData(45);

            binarytree.SearchNode(2);

            var linkedList = Datastructures.GetLinkList();

            linkedList.InsertFirst(5,10);
            linkedList.InsertFirst(6,25);
            linkedList.InsertFirst(9,48);

            var key = linkedList.Find(6);
            
            linkedList.Print();

            linkedList.Delete(6);

            linkedList.Print();


            Console.ReadLine();
        }
    }
}
