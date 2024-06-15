using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Graph
{
    class AllPathsSourceToTarget
    {
		public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
		{
			List<List<int>> result = new List<List<int>>();
			Queue<List<int>> paths = new Queue<List<int>>();
			paths.Enqueue(new List<int>() { 0 }); //add new list with item "0" into the queue

			int targetNode = graph.Length - 1;

			while (paths.Count > 0)
			{
				List<int> currentpath = paths.Dequeue();

				int lastNode = currentpath[currentpath.Count - 1];

				if (lastNode == targetNode)
				{
					result.Add(currentpath);
				}
				else
				{
					foreach (int neighbor in graph[lastNode])
					{
						List<int> path = new List<int>(currentpath);
						path.Add(neighbor);
						paths.Enqueue(path);
					}
				}
			}

			return result.ToArray();
		}
	}
}
/*
 797. All Paths From Source to Target
Medium

Given a directed acyclic graph (DAG) of n nodes labeled from 0 to n - 1, find all possible paths from node 0 to node n - 1, and return them in any order.

The graph is given as follows: graph[i] is a list of all nodes you can visit from node i (i.e., there is a directed edge from node i to node graph[i][j]).

 
Example 1:
Input: graph = [[1,2],[3],[3],[]]
Output: [[0,1,3],[0,2,3]]
Explanation: There are two paths: 0 -> 1 -> 3 and 0 -> 2 -> 3.
Example 2:


Input: graph = [[4,3,1],[3,2,4],[3],[4],[]]
Output: [[0,4],[0,3,4],[0,1,3,4],[0,1,2,3,4],[0,1,4]]
Example 3:

Input: graph = [[1],[]]
Output: [[0,1]]
Example 4:

Input: graph = [[1,2,3],[2],[3],[]]
Output: [[0,1,2,3],[0,2,3],[0,3]]
Example 5:

Input: graph = [[1,3],[2],[3],[]]
Output: [[0,1,2,3],[0,3]]
 */
