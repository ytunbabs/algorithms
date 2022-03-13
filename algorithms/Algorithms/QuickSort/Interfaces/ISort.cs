using System;
namespace Algorithms.QuickSort.Interfaces
{ 
    public interface ISort<T>
    {
        void Sort(T[] sortList, int left, int right);
        int Partition(T[] sortList, int left, int right);
    }
}

