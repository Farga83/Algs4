using System;
using System.Collections.Generic;
using System.Text;

namespace Algs4.Graphs {
    public class Graph {

        private IList<IList<int>> adj;
        private int edges;
        private int vertices;

        public Graph(GraphType graphType, IList<Tuple<int, int>> connections, int vertices) {
            if (connections == null) {
                throw new ArgumentNullException("connections");
            }
            this.vertices = vertices;
            this.edges = 0;
            this.adj = new List<IList<int>>();
            for (var i = 0; i < vertices; i++) {
                this.adj.Add(new List<int>());
            }
            if (graphType == GraphType.Undirected) {
                this.AddUndirectedEdges(connections);
            } else if (graphType == GraphType.Directed) {
                this.AddDirectedEdges(connections);
            } else {
                var msg = String.Format("Unknown GraphType {0}", graphType);
                throw new ArgumentException(msg);
            }
        }

        public IList<int> Adjacent(int vertex) {
            if (vertex > adj.Count -1) {
                var msg = String.Format(
                    "Vertex {0} outside the bounds known vertices",
                    vertex
                );
                throw new ArgumentException(msg);
            }
            return adj[vertex];
        }

        public int Vertices() {
            return this.vertices;
        }

        public int Edges() {
            return this.edges;
        }

        public void AddEdge(int origin, int destination) {
            adj[origin].Add(destination);
            edges++;
        }

        public override string ToString() {
            var builder = new StringBuilder();
            for (int i = 0; i < this.vertices; i++) {
                builder.Append(string.Join(" ", adj[i]));
                builder.AppendLine();
            }
            return builder.ToString();
        }

        private void AddDirectedEdges(IList<Tuple<int, int>> connections) {
            foreach (var connection in connections) {
                this.AddEdge(connection.Item1, connection.Item2);
            }
        }

        private void AddUndirectedEdges(IList<Tuple<int, int>> connections) {
            foreach (var connection in connections) {
                this.AddEdge(connection.Item1, connection.Item2);
                this.AddEdge(connection.Item2, connection.Item1);
            }
        }
    }
}
