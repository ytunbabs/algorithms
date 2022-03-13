using System;
namespace Algorithms.HeapSort.Interfaces
{
    public interface ISort
    {
        void Sort<T>(T[] sortList, int heapSize);
    }
}
