using System;
using Algorithms.MergeSort.Interfaces;

namespace Algorithms.MergeSort
{
    public class MergeSort<T> : ISort
    {
        public MergeSort()
        {
        }

        public void Sort<T>(T[] sortList, int start, int end)
        {
            if(start < end)
            {
                int mid = (start + end) / 2;
                Sort(sortList, start, mid);
                int secondMid = (start + end) % 2 == 0 ? mid : mid + 1;
                Sort(sortList, secondMid, end);
                Merge<T>(sortList, start,mid, end);
            }
        }

        public void Merge<T>(T[] sortList, int start, int mid, int end)
        {
            int l1 = (mid - start);
            int l2 = end - mid;

            T[] firstArray = new T[l1];
            T[] secondArray = new T[l2];

            for(int i=0; i<l1; i++)
            {
                firstArray[i] = sortList[start + i];
            }

            for (int i = 0; i < l2; i++)
            {
                secondArray[i] = sortList[mid + i];
            }


            int ia = 0;
            int ib = 0;

            for(int i=start; i<end; i++)
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
                else if(firstArray.Length > ia)
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


        }
    }
}
