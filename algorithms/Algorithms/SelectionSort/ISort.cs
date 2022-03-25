using System;
namespace Algorithms.SelectionSort.Interfaces
{
    public interface ISort<T>
    {
        void Sort(T[] sortList, int start, int end);
    }
}
