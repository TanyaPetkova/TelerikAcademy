namespace HashTableImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private const int InitialCapacity = 16;

        private LinkedList<KeyValuePair<K, T>>[] table;
        private int capacity;
        private int count;

        public HashTable()
        {
            this.capacity = InitialCapacity;
            this.table = new LinkedList<KeyValuePair<K, T>>[this.capacity];
            this.count = 0;
        }

        public int Capacity
        {
            get
            {
                return this.table.Length;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public IEnumerable<K> Keys
        {
            get
            {
                return this.table.Where(x => x != null).SelectMany(x => x).Select(y => y.Key);
            }
        }

        public T this[K key]
        {
            get
            {
                return this.Find(key);
            }

            set
            {
                this.Update(key, value);
            }
        }

        public void Add(K key, T value)
        {
            if (this.Count > this.capacity * 0.75)
            {
                this.ResizeTable();
            }

            int index = Math.Abs(key.GetHashCode() % this.Capacity);
            var elementToAdd = new KeyValuePair<K, T>(key, value);

            if (this.table[index] == null)
            {
                this.table[index] = new LinkedList<KeyValuePair<K, T>>();
            }

            var next = this.table[index].First;
            while (next != null)
            {
                if (next.Value.Key.Equals(key))
                {
                    throw new ArgumentException("There is such key already");
                }

                next = next.Next;
            }

            this.table[index].AddLast(elementToAdd);
            this.count++;
        }

        public T Find(K key)
        {
            int index = Math.Abs(key.GetHashCode() % this.Capacity);

            if (this.table[index] == null)
            {
                throw new ArgumentException("There is no element with this key");
            }
            else
            {
                var next = this.table[index].First;
                while (next != null)
                {
                    if (next.Value.Key.Equals(key))
                    {
                        return next.Value.Value;
                    }

                    next = next.Next;
                }

                throw new ArgumentException("There is no element with this key");
            }
        }

        public void Remove(K key)
        {
            int index = Math.Abs(key.GetHashCode() % this.Capacity);

            if (this.table[index] == null)
            {
                throw new ArgumentException("There is no element with this key");
            }
            else
            {
                var next = this.table[index].First;
                while (next != null)
                {
                    if (next.Value.Key.Equals(key))
                    {
                        this.table[index].Remove(next);
                        this.count--;
                        return;
                    }

                    next = next.Next;
                }

                throw new ArgumentException("There is no element with this key");
            }
        }

        public void Clear()
        {
            this.table = new LinkedList<KeyValuePair<K, T>>[InitialCapacity];
            this.count = 0;
        }

        public bool ContainsKey(K key)
        {
            int index = Math.Abs(key.GetHashCode() % this.Capacity);

            if (this.table[index] == null)
            {
                return false;
            }

            var chain = this.table[index];
            foreach (var pair in chain)
            {
                if (pair.Key.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var list in this.table)
            {
                if (list != null)
                {
                    foreach (var listItem in list)
                    {
                        yield return listItem;
                    }
                }
            }
        }

        private void ResizeTable()
        {
            LinkedList<KeyValuePair<K, T>>[] resizedTable = new LinkedList<KeyValuePair<K, T>>[this.Capacity * 2];
            for (int i = 0; i < this.table.Length; i++)
            {
                resizedTable[i] = this.table[i];
            }

            this.table = resizedTable;
        }

        private void Update(K key, T value)
        {
            if (this.Count > this.capacity * 0.75)
            {
                this.ResizeTable();
            }

            int index = Math.Abs(key.GetHashCode() % this.Capacity);
            var elementToAdd = new KeyValuePair<K, T>(key, value);

            if (this.table[index] == null)
            {
                this.table[index] = new LinkedList<KeyValuePair<K, T>>();
            }

            var next = this.table[index].First;
            while (next != null)
            {
                if (next.Value.Key.Equals(key))
                {
                    this.table[index].Remove(next);
                    var newPair = new KeyValuePair<K, T>(key, value);
                    this.table[index].AddFirst(newPair);
                    return;
                }

                next = next.Next;
            }

            this.table[index].AddLast(elementToAdd);
            this.count++;
        }
    }
}
