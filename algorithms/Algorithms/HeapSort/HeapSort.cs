using System;
using Algorithms.HeapSort.Interfaces;

namespace Algorithms.HeapSort
{
    public class HeapSort<T> : ISort
    {
        public HeapSort()
        {
        }

        public void Sort<T>(T[] sortList, int heapSize)
        {
            BuildMaxHeap(sortList, heapSize);

            for(int i=sortList.Length-1; i>0; i--)
            {
                T buffer = sortList[i];
                sortList[i] = sortList[0];
                sortList[0] = buffer;
                heapSize -= 1;
                MaxHeapify(sortList, 0, heapSize);

            }
        }

        void BuildMaxHeap<T>(T[] sortList, int heapSize)
        {
            
            int heapLength = (sortList.Length/2) % 2 == 0 ? sortList.Length/2 : sortList.Length/2 + 1;



            for(int i=heapLength; i>=0; i--)
            {
                MaxHeapify(sortList, i, heapSize);
            }
        }

        void MaxHeapify<T>(T[] sortList, int index, int heapSize)
        {
            int left = 2 * index;
            int right = (2 * index) + 1;
            int largest = -1;

            if(left <= heapSize && string.Compare(sortList[index].ToString(), sortList[left].ToString(), StringComparison.InvariantCulture) < 0){
                largest = left;
            }
            else
            {
                largest = index;
            }
            if (right <= heapSize  && string.Compare(sortList[largest].ToString(), sortList[right].ToString(), StringComparison.InvariantCulture) < 0)
            {
                largest = right;
            }

            if(largest != index)
            {
                T buffer = sortList[largest];
                sortList[largest] = sortList[index];
                sortList[index] = buffer;

                MaxHeapify(sortList, largest, heapSize);
            }

        }
    }

    
}
