namespace StackImplementation
{
    using System;

    public class Stack<T>
    {
        private static readonly int initialCapacity = 4;

        private T[] array = new T[initialCapacity];
        private int count;

        public Stack()
        {
            this.array = new T[initialCapacity];
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.array.Length;
            }
        }

        public T Peek()
        {
            return this.array[this.Count - 1];
        }

        public void Push(T element)
        {
            if (this.Capacity == this.Count)
            {
                Resize();
            }

            this.array[this.count] = element;
            this.count++;
        }

        public T Pop()
        {
            T popedElement = this.Peek();
            this.count--;
            return popedElement;
        }

        private void Resize()
        {
            T[] resizedArray = new T[2 * this.Capacity];
            for (int i = 0; i < this.array.Length; i++)
            {
                resizedArray[i] = this.array[i];
            }

            this.array = resizedArray;
        }
    }
}
