using System;
namespace Algorithms.MergeSort.Interfaces
{
    public interface ISort
    {
        void Sort<T>(T[] sortList, int start, int end);
    }
}
