namespace QueueImplementation
{
    using System;
    using System.Collections.Generic;

    public class Queue<T>
    {
        private LinkedList<T> linkedList;

        public Queue()
        {
            linkedList = new LinkedList<T>();
        }

        public int Count
        {
            get
            {
                return this.linkedList.Count;
            }
        }

        public T Peek()
        {
            return linkedList.First.Value;
        }

        public void Enqueue(T element)
        {
            linkedList.AddLast(element);
        }

        public T Dequeue()
        {
            T firstElement = this.Peek();
            this.linkedList.RemoveFirst();
            return firstElement;
        }
    }
}
