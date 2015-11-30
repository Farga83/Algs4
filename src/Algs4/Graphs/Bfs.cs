using System;
using System.Collections.Generic;
using System.Linq;

namespace Algs4.Graphs {
    public class Bfs {

        private bool[] marked;
        private int[] edgeTo;
        private int count;
        private readonly int root;

        public Bfs(Graph graph, int root) {
            if (graph == null) {
                throw new ArgumentNullException("graph");
            }
            this.marked = new bool[graph.Vertices()];
            this.edgeTo = Enumerable.Repeat(-1, graph.Vertices()).ToArray();
            this.count = 0;
            this.root = root;
            this.BreadthFirstSearch(graph, root);
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
                path.Reverse();
                return path;
            }
        }

        public void BreadthFirstSearch(Graph graph, int root) {
            var vertices = new Queue<int>();
            vertices.Enqueue(root);
            marked[root] = true;
            count++;
            while (vertices.Count > 0) {
                var currentVertice = vertices.Dequeue();
                foreach (var vert in graph.Adjacent(currentVertice)) {
                    edgeTo[vert] = currentVertice;
                    marked[vert] = true;
                    count++;
                    vertices.Enqueue(vert);
                }
            }
        }
    }
}
