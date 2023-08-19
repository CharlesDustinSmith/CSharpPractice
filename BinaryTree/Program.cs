// See https://aka.ms/new-console-template for more information
using System;

class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

class BinaryTree
{
    public Node Root;

    public BinaryTree()
    {
        Root = null;
    }

    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        if (data < root.Data)
        {
            root.Left = InsertRec(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = InsertRec(root.Right, data);
        }

        return root;
    }

    public void InOrderTraversal(Node root)
    {
        if (root != null)
        {
            InOrderTraversal(root.Left);
            Console.Write(root.Data + " ");
            InOrderTraversal(root.Right);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(70);
        tree.Insert(60);
        tree.Insert(80);

        Console.WriteLine("In-order traversal:");
        tree.InOrderTraversal(tree.Root);
    }
}

