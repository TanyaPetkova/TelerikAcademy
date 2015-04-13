namespace _11.LinkedListImplementation
{
    using System;

    public class LinkedList<T>
    {
        public LinkedList()
        {
            this.FirstElement = null;
        }

        public ListItem<T> FirstElement { get; set; }

        public int Count
        {
            get
            {
                return this.GetCount();
            }
        }

        /// <summary>
        /// Adds a new node containing the specified value at the end of the LinkedList<T>.
        /// </summary>
        /// <param name="value">The value to add at the end of the LinkedList<T>.</param>
        public void AddLast(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> currentItem = this.FirstElement;

                while (currentItem.NextItem != null)
                {
                    currentItem = currentItem.NextItem;
                }

                ListItem<T> lastItem = new ListItem<T>(value, currentItem);
                currentItem = lastItem;
            }
        }

        /// <summary>
        /// Adds the specified new node after the specified existing node.
        /// </summary>
        /// <param name="item">The node after which to insert the new node.</param>
        /// <param name="newItem">The new node to add to the LinkedList<T>.</param>
        public void AddAfter(ListItem<T> item, ListItem<T> newItem)
        {
            this.ValidateNullCondition(item);
            this.ValidateNullCondition(newItem);

            ListItem<T> prevNode = item.NextItem;
            item.NextItem = newItem;
            newItem.NextItem = prevNode;
        }

        /// <summary>
        /// Adds a new node containing the specified value after the specified existing node.
        /// </summary>
        /// <param name="item">The node after which to insert a new value.</param>
        /// <param name="value">The value to add to the LinkedList<T>.</param>
        /// <returns>The new node containing the added value.</returns>
        public ListItem<T> AddAfter(ListItem<T> item, T value)
        {
            this.ValidateNullCondition(item);

            ListItem<T> prevNode = item.NextItem;
            ListItem<T> newItem = new ListItem<T>(value, item);

            item.NextItem = newItem;
            newItem.NextItem = prevNode;

            return newItem;
        }

        /// <summary>
        /// Adds the specified new node before the specified existing node
        /// </summary>
        /// <param name="item">The node before which to insert the new node</param>
        /// <param name="newItem">The new node to add to the LinkedList<T>.</param>
        public void AddBefore(ListItem<T> item, ListItem<T> newItem)
        {
            this.ValidateNullCondition(item);
            this.ValidateNullCondition(newItem);

            ListItem<T> currentItem = this.FirstElement;
            if (currentItem == item)
            {
                this.FirstElement = new ListItem<T>(newItem);
                this.FirstElement.NextItem = currentItem;
            }
            else
            {
                while (currentItem.NextItem != item)
                {
                    currentItem = currentItem.NextItem;
                }

                currentItem.NextItem = newItem;
                newItem.NextItem = item;
            }
        }

        /// <summary>
        /// Removes the node at the start of the LinkedList<T>.
        /// </summary>
        public void RemoveFirst()
        {
            this.FirstElement = this.FirstElement.NextItem;
        }

        /// <summary>
        /// Removes the node at the end of the LinkedList<T>.
        /// </summary>
        public void RemoveLast()
        {
            ListItem<T> currentItem = this.FirstElement;

            while (currentItem.NextItem.NextItem != null)
            {
                currentItem = currentItem.NextItem;
            }

            currentItem.NextItem = null;
        }

        public override string ToString()
        {
            string[] result = new string[this.Count];

            ListItem<T> currentItem = this.FirstElement;

            result[0] = currentItem.Value.ToString();

            for (int i = 1; i < this.Count && currentItem.NextItem != null; i++)
            {
                currentItem = currentItem.NextItem;
                result[i] = currentItem.Value.ToString();
            }

            return string.Join(", ", result);
        }

        private int GetCount()
        {
            int count = 0;

            if (this.FirstElement != null)
            {
                count = 1;

                ListItem<T> currentItem = this.FirstElement;

                while (currentItem.NextItem != null)
                {
                    currentItem = currentItem.NextItem;
                    count += 1;
                }
            }

            return count;
        }

        private void ValidateNullCondition(ListItem<T> item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The list item cannot be null!");
            }
        }
    }
}
