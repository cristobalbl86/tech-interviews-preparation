using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Graph
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
    class CloneGraph
    {
        public static Node doCloneGraph(Node node)
        {
            if (node == null)
                return null;

            Hashtable ht = new Hashtable();

            return cloneNode(ht, node);
        }

        public static Node cloneNode(Hashtable ht, Node node)
        {
            if (ht.ContainsKey(node.val))
                return (Node)ht[node.val];

            Node copy = new Node(node.val);
            ht.Add(node.val, copy);
            foreach (Node neighbor in node.neighbors)
            {
                copy.neighbors.Add(cloneNode(ht, neighbor));
            }

            return copy;
        }
    }
}
/*
 133. Clone Graph
Medium

Given a reference of a node in a connected undirected graph.

Return a deep copy (clone) of the graph.

Each node in the graph contains a val (int) and a list (List[Node]) of its neighbors.

class Node {
    public int val;
    public List<Node> neighbors;
}
 

Test case format:

For simplicity sake, each node's value is the same as the node's index (1-indexed). For example, the first node with val = 1, the second node with val = 2, and so on. The graph is represented in the test case using an adjacency list.

Adjacency list is a collection of unordered lists used to represent a finite graph. Each list describes the set of neighbors of a node in the graph.

The given node will always be the first node with val = 1. You must return the copy of the given node as a reference to the cloned graph.
 */
