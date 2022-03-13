using System;
namespace Abstractions.Models
{
    public class ListNode<T>
    {
        public ListNode()
        {

        }

        public T Value;
        public ListNode<T> Next;
    }
}
