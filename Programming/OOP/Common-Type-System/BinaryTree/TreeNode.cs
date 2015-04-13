namespace BinaryTree
{
    using System;

    public class TreeNode<T> : IComparable<TreeNode<T>> where T : IComparable<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Parent { get; set; }
        public TreeNode<T> LeftChild { get; set; }
        public TreeNode<T> RightChild { get; set; }

        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Null values cannot be added!");
            }

            this.Value = value;
            this.Parent = null;
            this.LeftChild = null;
            this.RightChild = null;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            TreeNode<T> other = (TreeNode<T>)obj;
            return this.CompareTo(other) == 0;
        }

        public int CompareTo(TreeNode<T> other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}
