// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class BStarTreeNode
{
    public List<int> Keys;
    public List<BStarTreeNode> Children;
    public BStarTreeNode Parent;
    public bool IsLeaf;

    public BStarTreeNode()
    {
        Keys = new List<int>();
        Children = new List<BStarTreeNode>();
        Parent = null;
        IsLeaf = true;
    }
}

class BStarTree
{
    private BStarTreeNode Root;
    private int Degree;

    public BStarTree(int degree)
    {
        Root = new BStarTreeNode();
        Degree = degree;
    }

    public void Insert(int key)
    {
        // Implement insertion logic here
    }

    public void Display()
    {
        InOrderTraversal(Root);
    }

    private void InOrderTraversal(BStarTreeNode node)
    {
        if (node != null)
        {
            int i;
            for (i = 0; i < node.Keys.Count; i++)
            {
                if (!node.IsLeaf)
                {
                    InOrderTraversal(node.Children[i]);
                }
                Console.Write(node.Keys[i] + " ");
            }
            if (!node.IsLeaf)
            {
                InOrderTraversal(node.Children[i]);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BStarTree tree = new BStarTree(3); // Example degree of 3
        tree.Insert(10);
        tree.Insert(20);
        tree.Insert(5);
        tree.Insert(15);
        tree.Insert(25);

        Console.WriteLine("In-order traversal of B* tree:");
        tree.Display();
    }
}

