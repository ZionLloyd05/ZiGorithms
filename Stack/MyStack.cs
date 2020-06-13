using System;

namespace algorithm_v2.Stack
{
    /// <summary>Array Based Implelmentation of STACK</summary>
    public class MyStack<T>
    {
        internal int capacity;
        internal T[] stack;
        internal int top;

        public MyStack(int MaxElements)
        {
            capacity = MaxElements;
            stack = new T[capacity];
        }

        public int Push(T Element)
        {
            // Check for overflow
            if (top == capacity - 1) return -1;

            top += 1;
            stack[top] = Element;

            return 0;
        }

        public T Pop()
        {
            T RemovedElement;
            T temp = default;

            // check for underflow
            if (top <= 0) return temp;

            RemovedElement = stack[top];
            top -= 1;
            return RemovedElement;
        }

        public T Peep(int position)
        {
            T temp = default;
            if (position < capacity && position >= 0) return stack[position];

            return temp;
        }

        public T[] GetAllStackElements()
        {
            T[] Elements = new T[top + 1];
            //System.Collections.Array.Copy(stack, 0, Elements, 0, top + 1);
            return Elements;
        }
    }
}