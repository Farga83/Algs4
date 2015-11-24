using System;
using System.Collections.Generic;
using System.Text;

namespace Algs4.Graphs {
    public class Bfs {

        private IList<IList<int>> adjLists;
        private int vertices;
        private int edges;

        public Bfs(GraphType graphType, int v, IList<Tuple<int, int>> edges) {
            this.vertices = v;
            adjLists = new List<IList<int>>();
            for (int i = 0; i < v; i++) {
                adjLists.Add(new List<int>());
            }
            Action<int, int> addMethod;
            if (graphType == GraphType.Directed) {
                addMethod = (from, to) => AddEdge(from, to);
            } else if (graphType == GraphType.Undirected) {
                addMethod = (from, to) => AddUndirectedEdge(from, to);
            } else {
                var errorMsg =
                    String.Format("Unknown graphType {0}", graphType.ToString());
                throw new ArgumentException(errorMsg, "graphType");
            }
            ProcessGraph(edges, addMethod);
        }

        public void AddEdge(int from, int to) {
            adjLists[from].Add(to);
            edges++;
        }

        public int V() {
            return this.vertices;
        }

        public int E() {
            return this.edges;
        }

        public IEnumerable<int> Adj(int v) {
            if (v > this.vertices) {
                throw new ArgumentException("Vertice out of bounds");
            }
            return adjLists[v];
        }

        public override string ToString() {
            var builder = new StringBuilder();
            for (int i = 0; i < this.vertices; i++) {
                builder.Append(string.Join(" ", adjLists[i]));
                builder.AppendLine();
            }
            return builder.ToString();
        }

        private void ProcessGraph(IList<Tuple<int, int>> edges, Action<int, int> addMethod) {
            foreach (var edge in edges) {
                addMethod(edge.Item1, edge.Item2);
            }
        }

        private void AddUndirectedEdge(int from, int to) {
            AddEdge(from, to);
            AddEdge(to, from);
        }
    }
}
