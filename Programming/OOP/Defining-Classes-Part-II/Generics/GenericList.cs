namespace Generics
{
    using System;
    using System.Linq;

    public class GenericList<T> where T : IComparable<T>
    {
        private const int InitialSize = 4;

        private T[] elements;
        private int count;

        public GenericList(int capacity = InitialSize)
        {
            this.elements = new T[capacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set 
            {
                this.count = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.elements.Length;
            }
        }

        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                this.ResizeArray();
            }

            this.elements[count] = element;
            this.count++;
        }

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                T result = elements[index];
                return result;
            }
        }

        public T Remove(int index)
        {
            ValidateIndex(index);
            T removedElement = this.elements[index];

            for (int i = index; i < this.count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[this.count - 1] = default(T);
            this.count--;

            return removedElement;
        }

        public void Insert(T element, int index)
        {
            ValidateIndex(index);

            if (count >= elements.Length)
            {
                this.ResizeArray();
            }

            for (int i = count + 1; i >= index + 1; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = element;
            this.count++;
        }

        public void Clear()
        {
            this.elements = new T[InitialSize];
            Count = 0;
        }

        public int Find(T element)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public override string ToString()
        {
            return string.Join(" ", this.elements.Take(Count));
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
            }
        }

        private void ResizeArray()
        {
            int newSize = this.Capacity * 2;
            T[] newArray = new T[newSize];

            for (int i = 0; i < Capacity; i++)
            {
                newArray[i] = this.elements[i];
            }

            this.elements = newArray;
        }

        public T Min()
        {
            T minValue = this.elements[0];

            for (int i = 1; i < Count; i++)
            {
                if (this.elements[i].CompareTo(minValue) > 0)
                {
                    minValue = this.elements[i];
                }
            }

            return minValue;
        }

        public T Max()
        {
            T maxValue = this.elements[0];

            for (int i = 1; i < Count; i++)
            {
                if (this.elements[i].CompareTo(maxValue) < 0)
                {
                    maxValue = this.elements[i];
                }
            }

            return maxValue;
        }
    }
}
