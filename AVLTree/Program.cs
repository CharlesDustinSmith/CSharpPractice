// See https://aka.ms/new-console-template for more information
using System;

class Node
{
    public int Data;
    public int Height;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Height = 1;
        Left = null;
        Right = null;
    }
}

class AVLTree
{
    public Node Root;

    public AVLTree()
    {
        Root = null;
    }

    private int GetHeight(Node node)
    {
        if (node == null)
            return 0;
        return node.Height;
    }

    private int GetBalanceFactor(Node node)
    {
        if (node == null)
            return 0;
        return GetHeight(node.Left) - GetHeight(node.Right);
    }

    private Node RotateRight(Node y)
    {
        Node x = y.Left;
        Node T2 = x.Right;

        x.Right = y;
        y.Left = T2;

        y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
        x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

        return x;
    }

    private Node RotateLeft(Node x)
    {
        Node y = x.Right;
        Node T2 = y.Left;

        y.Left = x;
        x.Right = T2;

        x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
        y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

        return y;
    }

    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }

        if (data < root.Data)
        {
            root.Left = InsertRec(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = InsertRec(root.Right, data);
        }
        else // Duplicate data not allowed
        {
            return root;
        }

        root.Height = 1 + Math.Max(GetHeight(root.Left), GetHeight(root.Right));

        int balance = GetBalanceFactor(root);

        // Left Left Case
        if (balance > 1 && data < root.Left.Data)
        {
            return RotateRight(root);
        }

        // Right Right Case
        if (balance < -1 && data > root.Right.Data)
        {
            return RotateLeft(root);
        }

        // Left Right Case
        if (balance > 1 && data > root.Left.Data)
        {
            root.Left = RotateLeft(root.Left);
            return RotateRight(root);
        }

        // Right Left Case
        if (balance < -1 && data < root.Right.Data)
        {
            root.Right = RotateRight(root.Right);
            return RotateLeft(root);
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

    public void Display()
    {
        InOrderTraversal(Root);
    }
}

class Program
{
    static void Main(string[] args)
    {
        AVLTree tree = new AVLTree();
        tree.Insert(10);
        tree.Insert(20);
        tree.Insert(30);
        tree.Insert(40);
        tree.Insert(50);
        tree.Insert(25);

        Console.WriteLine("In-order traversal of AVL tree:");
        tree.Display();
    }
}

