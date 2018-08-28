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

            Console.WriteLine("Result : " + String.Join<int>(" ",arr));


            var binarytree = Datastructures.GetBinaryTree();

            //for (int i = 50; i < 100; i++)
            //{
            //    binarytree.InsertData(i);
            //}

            //for (int i = 50; i > 0; i--)
            //{
            //    binarytree.InsertData(i);
            //}

            binarytree.InsertData(5);
            binarytree.InsertData(10);
            binarytree.InsertData(23);
            binarytree.InsertData(3);
            binarytree.InsertData(2);
            binarytree.InsertData(4);
            binarytree.InsertData(45);


            Console.ReadLine();
        }
    }
}
