using System;
using Algorithms.MergeSort.Interfaces;

namespace Algorithms.MergeSort
{
    public class MergeSort<T> : ISort<T>
    {
        public MergeSort()
        {
        }

        public void Sort(T[] sortList, int start, int end)
        {
            if(start < end)
            {
                int mid = (start + end) / 2;
                Sort(sortList, start, mid);
                int secondMid = (start + end) % 2 == 0 ? mid : mid + 1;
                Sort(sortList, secondMid, end);
                Merge(sortList, start,mid, end);
            }
        }

        public void Merge(T[] sortList, int start, int mid, int end)
        {
            int l1 = (mid - start);
            int l2 = end - mid;

            T[] firstArray = new T[l1];
            T[] secondArray = new T[l2];

            for(int i=start; i<l1+start; i++)
            {
                firstArray[i-start] = sortList[i];
            }

            for (int i = mid; i < l2 + mid; i++)
            {
                secondArray[i-mid] = sortList[i];
            }


            int ia = 0;
            int ib = 0;

            for (int i = start; i < end; i++)
            {
                if (firstArray.Length > ia && secondArray.Length > ib)
                {

                    if (string.Compare(firstArray[ia].ToString(), secondArray[ib].ToString(), StringComparison.InvariantCulture) < 0)

                    {
                        sortList[i] = firstArray[ia];
                        ia += 1;
                    }
                    else
                    {
                        sortList[i] = secondArray[ib];
                        ib += 1;
                    }
                }
                else if (firstArray.Length > ia)
                {
                    sortList[i] = firstArray[ia++];
                }
                else if(secondArray.Length > ib)
                {
                    sortList[i] = secondArray[ib];
                }
            }

        }
    }
}
