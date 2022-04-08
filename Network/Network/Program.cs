using System;
using System.Collections.Generic;

class GFG
{

    // Function to visit the nodes of a graph
    public static void DFS(Dictionary<int, List<int>> adj, int node, bool[] visited)
    {
        // If current node is already visited
        if (visited[node])
            return;

        // If current node is not visited
        visited[node] = true;

        // Recurse for neighbouring nodes
        foreach (int x in adj[node])
        {

            // If the node is not visited
            if (visited[x] == false)
                DFS(adj, x, visited);
        }
    }

    // Utility function to check if it is
    // possible to connect all computers or not
    public static int makeConnectedUtil(int N, int[,] connections, int M)
    {
        // Stores whether a
        // node is visited or not
        bool[] visited = new bool[N];

        // Build the adjacency list
        Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();

        // Initialize the adjacency list
        for (int i = 0; i < N; i++)
        {
            adj[i] = new List<int>();
        }

        // Stores count of edges
        int edges = 0;

        // Building adjacency list
        // from the given edges
        for (int i = 0; i < M; i++)
        {

            // Get neighbours list
            List<int> l1 = adj[connections[i, 0]];
            List<int> l2 = adj[connections[i, 1]];

            // Add edges
            l1.Add(connections[i, 1]);
            l2.Add(connections[i, 0]);

            // Increment count of edges
            edges += 1;
        }

        // Stores count of components
        int components = 0;

        for (int i = 0; i < N; ++i)
        {

            // If node is not visited
            if (visited[i] == false)
            {

                // Increment components
                components += 1;

                // Perform DFS
                DFS(adj, i, visited);
            }
        }

        // At least N - 1 edges are required
        if (edges < N - 1)
            return -1;

        // Count redundant edges
        int redundant = edges - ((N - 1) - (components - 1));

        // Check if components can be
        // rearranged using redundant edges
        if (redundant >= (components - 1))
            return components - 1;

        return -1;
    }

    public static int minOperations(int compNodes, List<int> compFrom, List<int> compTo)
    {
        int[,] connections = new int[compFrom.Count, 2];

        for (int i = 0; i < compFrom.Count; i++)
        {
            connections[i,0] = compFrom[i]-1;
            connections[i,1] = compTo[i]-1;
        }

        // Stores counmt of minimum
        // operations required
        int minOps = makeConnectedUtil(compNodes, connections, compFrom.Count);

        // Print the minimum number
        // of operations required
        //Console.WriteLine(minOps);
        return minOps;
    }

    static void Main()
    {
        //Given number of computers
        int N = 4;

        int compNodes = N;
        List<int> compFrom = new List<int>() { 4, 1, 1, 3 };
        List<int> compTo = new List<int>() { 3, 2, 3, 2 };

        Console.WriteLine(minOperations(compNodes, compFrom, compTo));

        Console.ReadLine();
    }
}