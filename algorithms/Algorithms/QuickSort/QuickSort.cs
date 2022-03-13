using System;
namespace Algorithms.QuickSort.Interfaces
{
    public class QuickSort<T>: ISort<T>
    {
        public QuickSort()
        {

        }

        public int Partition(T[] sortList, int left, int right)
        {
            int p = right;
            int h = left;

            for(int i=left; i<right; i++)
            {
                if(string.Compare(sortList[i].ToString(), sortList[p].ToString(), StringComparison.InvariantCulture) < 0)
                {
                    T buffer = sortList[h];
                    sortList[h] = sortList[i];
                    sortList[i] = buffer;

                    h += 1;
                }
            }

            T tempBuffer = sortList[p];
            sortList[p] = sortList[h];
            sortList[h] = tempBuffer;

            return h;
        }

        public void Sort(T[] sortList, int left, int right)
        {
            if(left < right)
            {
                int partition = Partition(sortList, left, right);
                Sort(sortList, left, partition - 1);
                Sort(sortList, partition + 1, right);
            }
        }
    }
}
