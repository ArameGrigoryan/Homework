using System;
using System.Collections.Generic;

namespace Container
{
    public class MyQueue<T> where T : struct
    {
        List<T> queue = null;
        private int _size = 0;
        public int Size
        {
            get
            {
                return _size;
            }
        }
        public MyQueue()
        {
            queue = new();
            _size = 0;
        }
        public void Push(T val)
        {
            queue.Add(val);
            ++_size;
        }
        public void Pop()
        {
            if (_size == 0)
            {
                Console.WriteLine("MyQueue is empty!!");
                return;
            }
            queue.RemoveAt(0);
            --_size;
        }
        public T Peek()
        {
            return queue[0];
        }
        public bool Empty()
        {
            return _size == 0;
        }
    }
}