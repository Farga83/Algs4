using System.Collections.Generic;
using System.Linq;

namespace Algs4.Graphs {
    public class Dfs {

        private bool[] marked;
        private int[] edgeTo;
        private int count;
        private readonly int root;

        public Dfs(Graph graph, int root) {
            this.marked = new bool[graph.Vertices()];
            this.edgeTo = Enumerable.Repeat(-1, graph.Vertices()).ToArray();
            this.count = 0;
            this.root = root;
            this.DepthFirstSearch(graph, root);
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

        private void DepthFirstSearch(Graph graph, int vertice) {
            count++;
            marked[vertice] = true;
            foreach (var node in graph.Adjacent(vertice)) {
                if (!marked[node]) {
                    DepthFirstSearch(graph, node);
                    edgeTo[node] = vertice;
                }
            }
        }
    }
}
