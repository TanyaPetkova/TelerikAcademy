namespace BinaryTree
{
    using System;

    class Test
    {
        static void Main()
        {
            BinarySearchTree<string> tree = new BinarySearchTree<string>();

            tree.AddElement("Pesho");
            tree.AddElement("Gosho");
            tree.AddElement("Tosho");
            tree.AddElement("Misho");
            Console.WriteLine(tree);

            BinarySearchTree<string> tree2 = tree.Clone() as BinarySearchTree<string>;

            Console.WriteLine(tree2);
            Console.WriteLine(tree.Equals(tree2)); //True
            Console.WriteLine(tree.GetHashCode());
            Console.WriteLine(tree2.GetHashCode());
            tree.RemoveElement("Pesho");
            Console.WriteLine(tree);
            Console.WriteLine(tree2);
            Console.WriteLine(tree.Equals(tree2)); //False
            Console.WriteLine(tree.GetHashCode());
            Console.WriteLine(tree2.GetHashCode());
        }
    }
}
