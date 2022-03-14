using System;
namespace Abstractions.Stack.Interfaces
{
    public interface IStack<T>
    {
        bool Empty();
        T Peek();
        T Pop();
        void Push(T item);
    }
}
