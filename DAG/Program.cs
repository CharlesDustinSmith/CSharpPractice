// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class DAGNode
{
    public int Data;
    public List<DAGNode> Children;

    public DAGNode(int data)
    {
        Data = data;
        Children = new List<DAGNode>();
    }
}

class DAG
{
    private List<DAGNode> Nodes;

    public DAG()
    {
        Nodes = new List<DAGNode>();
    }

    public void AddNode(int data)
    {
        Nodes.Add(new DAGNode(data));
    }

    public void AddEdge(int fromData, int toData)
    {
        DAGNode fromNode = Nodes.Find(node => node.Data == fromData);
        DAGNode toNode = Nodes.Find(node => node.Data == toData);

        if (fromNode != null && toNode != null)
        {
            fromNode.Children.Add(toNode);
        }
    }

    public List<int> TopologicalSort()
    {
        List<int> result = new List<int>();
        HashSet<DAGNode> visited = new HashSet<DAGNode>();

        foreach (DAGNode node in Nodes)
        {
            if (!visited.Contains(node))
            {
                TopologicalSortDFS(node, visited, result);
            }
        }

        result.Reverse(); // Reverse the result to get the topological order
        return result;
    }

    private void TopologicalSortDFS(DAGNode node, HashSet<DAGNode> visited, List<int> result)
    {
        visited.Add(node);

        foreach (DAGNode child in node.Children)
        {
            if (!visited.Contains(child))
            {
                TopologicalSortDFS(child, visited, result);
            }
        }

        result.Add(node.Data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        DAG dag = new DAG();
        dag.AddNode(1);
        dag.AddNode(2);
        dag.AddNode(3);
        dag.AddNode(4);
        dag.AddNode(5);

        dag.AddEdge(1, 2);
        dag.AddEdge(1, 3);
        dag.AddEdge(2, 4);
        dag.AddEdge(3, 4);
        dag.AddEdge(4, 5);

        List<int> topologicalOrder = dag.TopologicalSort();

        Console.WriteLine("Topological order of the DAG:");
        foreach (int nodeData in topologicalOrder)
        {
            Console.Write(nodeData + " ");
        }
    }
}

