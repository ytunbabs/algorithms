using System;
using Abstractions.Interfaces;
using Abstractions.Models;

namespace Abstractions
{
    public class SingleLinkedList<ListNode, V> : IListContract<V>
    {
        public ListNode<V> List = null;

        public SingleLinkedList()
        {
        }

        public bool Delete(V item)
        {
            // head is null
            if(List == null)
            {
                return false;
            }
            // node is head
            //
            if (string.Compare(List.Value.ToString(), item.ToString(), StringComparison.InvariantCulture) == 0)
            {
                List = List.Next;
                return true;
            }
            var node = List;
            ListNode<V> prev = null;

            while(string.Compare(node.Value.ToString(), item.ToString(), StringComparison.InvariantCulture) != 0)
            {
                prev = node;
                node = node.Next;
            }
            
            if(node == null)
            {
                return false; //not found
            }
            else if(node.Next == null)
            {
                prev.Next = null;
            }

            else
            {
                prev.Next = node.Next;
            }
            return true;

        }

        public void Insert(V newItem)
        {
            //List is empty
            if(List == null)
            {
                List = new ListNode<V>();
                List.Value = newItem;
                List.Next = null;
                return;
            }
            var current = List;

            //Head is not null && Tail is not null
            while (current.Next != null)
            {
                current = current.Next;
            }

            //Current points to the Tail and it is not null.
            var newNode = new ListNode<V>();
            newNode.Value = newItem;
            current.Next = newNode;
            
        }

        public ListNode<V> Search(V searchItem)
        {
            var current = List;
            while(current != null && string.Compare(current.Value.ToString(),  searchItem.ToString(), StringComparison.InvariantCulture) != 0)
            {
                current = current.Next;
            }

            return current;
        }

        public void Print()
        {
            var list = List;

            while(list != null)
            {
                Console.WriteLine(list.Value.ToString());
                list = list.Next;
            }
        }

        public ListNode<V> Reverse(ListNode<V> originalList)
        {
            ListNode<V> t, y, r = null;

            y = originalList;

            while(y != null)
            {
                t = y.Next;
                y.Next = r;
                r = y;
                y = t;
            }

            return y;
        }
    }
}
