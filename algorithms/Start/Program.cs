using System;
using Algorithms.HeapSort;
using Algorithms.InsertionSort;
using Algorithms.MergeSort;
using Algorithms.SelectionSort;
using Abstractions;
using Abstractions.Models;
using Algorithms.QuickSort.Interfaces;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 names");
            string[] sortList = new string[10];

            for (int i = 0; i <10; i++)
            {
                sortList[i] = Console.ReadLine();
            }

            //HeapSort<string> heapSort = new HeapSort<string>();

            //InsertionSort<string> insertionSort = new InsertionSort<string>();
            //insertionSort.Sort<string>(sortList);

            QuickSort<string> quickSort = new QuickSort<string>();
            quickSort.Sort(sortList, 0, sortList.Length - 1);

            //heapSort.Sort(sortList, 2);
            Console.WriteLine("----------------------------------------------");

            for (int i = 0; i < sortList.Length; i++)
            {
                Console.WriteLine(sortList[i]);
            }

            //Console.WriteLine("Please enter 5 names");
            //var linkedList = new SingleLinkedList<ListNode<string>, string>();
            //for (int i=0; i<5; i++)
            //{
            //    linkedList.Insert(Console.ReadLine());
            //}
            //Console.WriteLine("You inserted:");
            //linkedList.Print();

            //Console.WriteLine("Please enter a string to delete.");
            //var deleteValue = Console.ReadLine();

            //linkedList.Delete(deleteValue);
            //linkedList.Print();

            //Console.WriteLine("Please search for a string.");
            //var searchValue = Console.ReadLine();

            //var node = linkedList.Search(searchValue);

            //if(node == null)
            //{
            //    Console.WriteLine($"{searchValue} not found.");
            //}
            //else
            //{
            //    Console.WriteLine($"{node.Value.ToString()} found.");
            //}

            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Final List:");
            //linkedList.Print();
        }
    }
}
