namespace HashSetImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using HashTableImplementation;

    public class HashSet<T> : IEnumerable<T>
    {
        private HashTable<int, T> hashTable;

        public HashSet()
        {
            this.hashTable = new HashTable<int, T>();
        }

        public HashSet(IEnumerable<T> collection)
        {
            this.hashTable = new HashTable<int, T>();
            foreach (var item in collection)
            {
                this.Add(item);
            }
        }

        public int Count
        {
            get
            {
                return this.hashTable.Count;
            }
        }

        public T this[T index]
        {
            get
            {
                return hashTable[index.GetHashCode()];
            }
            set
            {
                hashTable[index.GetHashCode()] = value;
            }
        }

        public void Add(T value)
        {
            if (!this.hashTable.ContainsKey(value.GetHashCode()))
            {
                this.hashTable.Add(value.GetHashCode(), value);
            }
        }

        public T Find(T value)
        {
            return this.hashTable.Find(value.GetHashCode());
        }

        public void Remove(T value)
        {
            this.hashTable.Remove(value.GetHashCode());
        }

        public void Clear()
        {
            this.hashTable.Clear();
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            HashSet<T> newTable = new HashSet<T>();
            foreach (var item in this)
            {
                foreach (var el in other)
                {
                    if (el.Equals(item))
                    {
                        newTable.Add(item);
                    }
                }
            }

            this.Clear();
            foreach (var item in newTable)
            {
                this.Add(item);
            }
        }

        public void UnionWith(IEnumerable<T> other)
        {
            foreach (var item in other)
            {
                this.Add(item);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var pair in this.hashTable)
            {
                yield return pair.Value;
            }
        }
    }
}
