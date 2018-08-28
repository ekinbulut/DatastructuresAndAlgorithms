using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresAndAlgorithms
{
    public static class Algorithm
    {
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;

                        Console.WriteLine("Order :" + String.Join<int>(" ", arr));
                    }
                }
            }

            return arr;
        }

        public static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;

                Console.WriteLine("Order : " + String.Join<int>(" ", arr) + " @Index : " + i + " Min Index : " + min_idx);

            }

            return arr;
        }

        public static int[] InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key, 
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;


                }
                arr[j + 1] = key;

                Console.WriteLine("Order : " + String.Join<int>(" ", arr));
            }

            return arr;
        }

        public static int[] MergeSort(int[] arr)
        {
            Sort(arr, 0, arr.Length);

            return arr;
        }

        static void Sort(int[] arr, int low, int high)
        {
            int n = high - low;

            if (n <= 1)
            {
                return;
            }

            int mid = low + n / 2;

            Sort(arr, low, mid);
            Sort(arr, mid, high);

            int[] aux = new int[n];

            int i = low, j = mid;

            for (int k = 0; k < n; k++)
            {
                if (i == mid)
                {
                    aux[k] = arr[j++];
                }
                else if (j == high)
                {
                    aux[k] = arr[i++];
                }
                else if (arr[j].CompareTo(arr[i]) < 0)
                {
                    aux[k] = arr[j++];
                }
                else
                {
                    aux[k] = arr[i++];
                }
            }

            for (int k = 0; k < n; k++)
            {
                arr[low + k] = aux[k];
            }
        }
    }
}
