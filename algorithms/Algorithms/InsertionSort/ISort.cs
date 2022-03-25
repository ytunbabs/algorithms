using System;
namespace Algorithms.InsertionSort
{
    public interface ISort<T>
    {
        void Sort(T[] sortList);
    }
}
