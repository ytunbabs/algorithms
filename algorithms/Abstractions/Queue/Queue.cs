using System;
using Abstractions.Queue.Interfaces;

namespace Abstractions.Queue
{
    public class Queue<T> : IQueue<T>
    {
        private int _size;
        private int _head;
        private int _tail;
        private T[] _store;

        public Queue(int size)
        {
            _size = size;
            _store = new T[_size];
            _tail = -1;
        }

        public T Dequeue()
        {
            if (!Empty())
            {
                return _store[_head++];

            }
            else
            {
                throw new Exception("stream underflow!");
            }
        }

        public bool Empty()
        {
            return _tail + 1 == _head;
        }

        public void Enqueue(T item)
        {
            if (!Full())
            {
                _store[++_tail] = item;
            }

            throw new Exception("Queue Overflow");
        }

        public bool Full()
        {
            return _tail == _size - 1;
        }

        public T Peek()
        {
            return _store[_head];
        }
    }
}
