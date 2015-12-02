using System;
using System.Collections.Generic;
using System.Linq;

namespace Algs4.Graphs {
    public class Dfs {

        private bool[] marked;
        private int[] edgeTo;
        private int[] distTo;
        private int count;
        private readonly int root;

        public Dfs(Graph graph, int root) {
            if (graph == null) {
                throw new ArgumentNullException("graph");
            }
            this.marked = new bool[graph.Vertices()];
            this.edgeTo = Enumerable.Repeat(-1, graph.Vertices()).ToArray();
            this.distTo = Enumerable.Repeat(-1, graph.Vertices()).ToArray();
            this.count = 0;
            this.root = root;
            this.DepthFirstSearch(graph, root, 0);
        }

        public bool Marked(int v) {
            return this.marked[v];
        }

        public int Count() {
            return this.count;
        }

        public bool HasPathTo(int v) {
            return edgeTo[v] != -1;
        }

        public int DistanceTo(int v) {
            return distTo[v];
        }

        public IEnumerable<int> PathTo(int v) {
            if (!HasPathTo(v)) {
                return null;
            } else {
                var path = new List<int>();
                for (var x = v; x != root; x = edgeTo[x]) {
                    path.Add(x);
                }
                // This is dumb. Why doesn't mono have Stack<T>
                path.Reverse();
                return path;
            }
        }

        private void DepthFirstSearch(Graph graph, int vertice, int dist) {
            count++;
            marked[vertice] = true;
            distTo[vertice] = dist;
            foreach (var node in graph.Adjacent(vertice)) {
                if (!marked[node]) {
                    DepthFirstSearch(graph, node, dist + 1);
                    edgeTo[node] = vertice;
                }
            }
        }
    }
}
