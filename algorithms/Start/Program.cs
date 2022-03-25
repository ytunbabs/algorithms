using System;
using Algorithms.HeapSort;
using Algorithms.InsertionSort;
using Algorithms.MergeSort;
using Algorithms.SelectionSort;
using Abstractions;
using Abstractions.Models;
using Algorithms.QuickSort.Interfaces;
using CommonAlgorithms;
using Abstractions.Graph;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {

            //infix operation:


            //string expression = "(2*(((9-1)/4)+3))";
            //InfixCalculation infixCalculator = new InfixCalculation();
            //var calcValue = infixCalculator.Calculate(expression);

            Console.WriteLine("Please enter 10 names");
            string[] sortList = new string[10];

            for (int i = 0; i < 10; i++)
            {
                sortList[i] = Console.ReadLine();
            }
            MergeSort<string> mergeSort = new MergeSort<string>();
            mergeSort.Sort(sortList, 0, sortList.Length);
            //HeapSort<string> heapSort = new HeapSort<string>();

            //InsertionSort<string> insertionSort = new InsertionSort<string>();
            //insertionSort.Sort<string>(sortList);

            //QuickSort<string> quickSort = new QuickSort<string>();
            //quickSort.Sort(sortList, 0, sortList.Length - 1);

            //heapSort.Sort(sortList);
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

            //Graph<string> g = new Graph<string>(true, 4);

            //g.InsertEdge(0, 1);
            //g.InsertEdge(0, 2);
            //g.InsertEdge(1, 2);
            //g.InsertEdge(2, 0);
            //g.InsertEdge(2, 3);
            //g.InsertEdge(3, 3);

            //Console.Write("Following is Breadth First " +
            //      "Traversal(starting from " +
            //      "vertex 2)\n");

            //g.DFS(2);

            Console.ReadKey();
        }
    }
}
