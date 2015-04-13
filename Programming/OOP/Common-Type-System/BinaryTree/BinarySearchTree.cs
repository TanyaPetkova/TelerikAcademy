namespace BinaryTree
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class BinarySearchTree<T> : ICloneable, IEnumerable<TreeNode<T>> where T : IComparable<T>
    {
        private TreeNode<T> root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public void AddElement(T value)
        {
            this.root = AddElement(value, null, root);
        }

        private TreeNode<T> AddElement(T value, TreeNode<T> parentNode, TreeNode<T> node)
        {
            if (node == null)
            {
                node = new TreeNode<T>(value);
                node.Parent = parentNode;
            }
            else
            {
                int compareTo = value.CompareTo(node.Value);

                if (compareTo < 0)
                {
                    node.LeftChild = AddElement(value, node, node.LeftChild);
                }
                else if (compareTo > 0)
                {
                    node.RightChild = AddElement(value, node, node.RightChild);
                }
            }

            return node;
        }

        public TreeNode<T> SearchElement(T value)
        {
            TreeNode<T> node = this.root;

            while (node != null)
            {
                int compareTo = value.CompareTo(node.Value);

                if (compareTo < 0)
                {
                    node = node.LeftChild;
                }
                else if (compareTo > 0)
                {
                    node = node.RightChild;
                }
                else
                {
                    break;
                }
            }

            return node;
        }

        public void RemoveElement(T value)
        {
            TreeNode<T> nodeToDelete = SearchElement(value);

            if (nodeToDelete != null)
            {
                RemoveElement(nodeToDelete);
            }
        }

        private void RemoveElement(TreeNode<T> node)
        {
            if (node.LeftChild != null && node.RightChild != null)
            {
                TreeNode<T> replacement = node.RightChild;

                while (replacement.LeftChild != null)
                {
                    replacement = replacement.LeftChild;
                }

                node.Value = replacement.Value;
                node = replacement;

                TreeNode<T> theChild = node.LeftChild != null ? node.LeftChild : node.RightChild;

                if (theChild != null)
                {
                    theChild.Parent = node.Parent;

                    if (node.Parent == null)
                    {
                        root = theChild;
                    }
                    else
                    {
                        if (node.Parent.LeftChild == node)
                        {
                            node.Parent.LeftChild = theChild;
                        }
                        else
                        {
                            node.Parent.RightChild = theChild;
                        }
                    }
                }
                else
                {
                    if (node.Parent == null)
                    {
                        root = null;
                    }
                    else
                    {
                        if (node.Parent.LeftChild == null)
                        {
                            node.Parent.LeftChild = null;
                        }
                        else
                        {
                            node.Parent.RightChild = null;
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            return string.Join(" ", this);
        }

        public override bool Equals(object obj)
        {
            BinarySearchTree<T> tree = obj as BinarySearchTree<T>;

            if (tree == null)
            {
                return false;
            }

            if (tree.ToString() != this.ToString())
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = 1;

            foreach (var item in this)
            {
                hashCode ^= item.GetHashCode(); 
            }

            return hashCode;
        }

        public static bool operator ==(BinarySearchTree<T> firstTree, BinarySearchTree<T> secondTree)
        {
            return BinarySearchTree<T>.Equals(firstTree, secondTree);
        }

        public static bool operator !=(BinarySearchTree<T> firstTree, BinarySearchTree<T> secondTree)
        {
            return !BinarySearchTree<T>.Equals(firstTree, secondTree);
        }

        public object Clone()
        {
            BinarySearchTree<T> tree = new BinarySearchTree<T>();

            foreach (TreeNode<T> node in this)
            {
                tree.AddElement(node.Value);
            }

            return tree;
        }

        public IEnumerator<TreeNode<T>> GetEnumerator()
        {
            if (root == null)
            {
                throw new ArgumentNullException("An empty collection cannot be interated!");
            }

            TreeNode<T> currentNode;

            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();

            stack.Push(root);

            while (stack.Count > 0)
            {
                currentNode = stack.Pop();

                if (currentNode.LeftChild != null)
                {
                    stack.Push(currentNode.LeftChild);
                }

                if (currentNode.RightChild != null)
                {
                    stack.Push(currentNode.RightChild);
                }

                yield return currentNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
