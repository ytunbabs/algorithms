using System;
using Algorithms.InsertionSort;

namespace Algorithms.SelectionSort
{
    public class SelectionSort<T> : ISort<T>
    {
        public SelectionSort()
        {
        }

        public void Sort(T[] sortList)
        {
            for(int i=0; i<sortList.Length; i++)
            {
                for(int j=i+1; j<sortList.Length; j++)
                {
                    if(string.Compare(sortList[i].ToString(), sortList[j].ToString(), StringComparison.InvariantCulture) > 0)
                    {
                        //swap
                        T buffer = sortList[i];
                        sortList[i] = sortList[j];
                        sortList[j] = buffer;

                    }
                }
            }
        }
    }
}
