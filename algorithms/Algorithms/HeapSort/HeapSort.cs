using System;
using Algorithms.HeapSort.Interfaces;

namespace Algorithms.HeapSort
{
    public class HeapSort<T> : ISort<T>
    {
        public HeapSort()
        {
        }

        public void Sort(T[] sortList)
        {
            int heapSize = BuildMaxHeap(sortList);

            for(int i=sortList.Length-1; i>0; i--)
            {
                T buffer = sortList[i];
                sortList[i] = sortList[0];
                sortList[0] = buffer;
                heapSize -= 1;
                MaxHeapify(sortList, 0, heapSize);

            }
        }

        int BuildMaxHeap(T[] sortList)
        {
            
            int heapSize = (sortList.Length / 2)-1;

            //int heapSize = sortList.Length / 2;

            for(int i=heapSize; i>=0; i--)
            {
                MaxHeapify(sortList, i, heapSize);
            }

            return heapSize;
        }

        void MaxHeapify(T[] sortList, int index, int heapSize)
        {
            int left = 2 * index + 1;
            int right = (2 * index) + 2;
            int largest = index;

            if(left < heapSize && string.Compare(sortList[index].ToString(), sortList[left].ToString(), StringComparison.InvariantCulture) < 0){
                largest = left;
            }
            else
            {
                largest = index;
            }
            if (right < heapSize && string.Compare(sortList[largest].ToString(), sortList[right].ToString(), StringComparison.InvariantCulture) < 0)
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
