using System;
namespace Algorithms.MergeSort.Interfaces
{
    public interface ISort<T>
    {
        void Sort(T[] sortList, int start, int end);
        void Merge(T[] sortList, int start, int mid, int end);
    }
}
