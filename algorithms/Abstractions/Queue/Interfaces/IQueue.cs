using System;
namespace Abstractions.Queue.Interfaces
{
    public interface IQueue<T>
    {
        bool Empty();
        bool Full();
        T Peek();
        T Dequeue();
        void Enqueue(T item);

    }
}
