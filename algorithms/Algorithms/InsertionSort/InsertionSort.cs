using System;
namespace Algorithms.InsertionSort
{
    public class InsertionSort<T> : ISort
    {
        public InsertionSort()
        {
        }

        public void Sort<T>(T[] sortList)
        {
            for(int i=1; i<sortList.Length; i++)
            {
                T key = sortList[i];
                int j = i-1;
                while (j >= 0 && (string.Compare(sortList[j].ToString(), key.ToString(), StringComparison.InvariantCulture) > 0))
                {
                    sortList[j + 1] = sortList[j--];
                }
                sortList[j + 1] = key;
            }
        }
    }
}
