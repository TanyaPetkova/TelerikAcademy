namespace _11.LinkedListImplementation
{
    public class ListItem<T>
    {
        public ListItem(T value)
        {
            this.Value = value;
            this.NextItem = null;
        }

        public ListItem(T value, ListItem<T> prevItem)
            : this(value)
        {
            prevItem.NextItem = this;
        }

        public ListItem(ListItem<T> item)
        {
            this.Value = item.Value;
            this.NextItem = item.NextItem;
        }

        public T Value { get; set; }

        public ListItem<T> NextItem { get; set; }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
