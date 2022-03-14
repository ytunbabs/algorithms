using System;
using Abstractions.Stack.Interfaces;

namespace Abstractions.Stack
{
    public class Stack<T> : IStack<T>
    {
        private int _stackSize;
        private T[] _repository;
        private int top = -1;

        public Stack(int length)
        {
            _stackSize = length;
            _repository = new T[length];
        }

        public bool Empty()
        {

            return top < 0;
        }

        public T Peek()
        {
            return _repository[top];
        }

        public T Pop()
        {
            if (!Empty())
            {
                return _repository[top--];
                
            }
            else
            {
                throw (new Exception("overflow exception - attempt to pop an empty stack"));
            }
        }

        public void Push(T item)
        {
            _repository[++top] = item;
        }
    }
}
