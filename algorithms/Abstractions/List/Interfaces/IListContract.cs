using System;
using Abstractions.Models;

namespace Abstractions.Interfaces
{
    public interface IListContract<T>
    {
        void Insert(T newItem);
        bool Delete(T item);
        ListNode<T> Search(T searchItem);
        void Print();
        ListNode<T> Reverse(ListNode<T> originalList);
    }
}
