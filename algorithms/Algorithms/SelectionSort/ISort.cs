using System;
namespace Algorithms.SelectionSort.Interfaces
{
    public interface ISort
    {
        void Sort<T>(T[] sortList, int start, int end);
    }
}
