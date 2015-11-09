using System;
using System.Collections.Generic;

namespace Algs4.Graphs {
    public class Graph {

        private IList<IList<int>> adj;
        private int edges;

        public Graph(GraphType graphType, IList<Tuple<int, int>> connections) {
            if (connections == null) {
                throw new ArgumentNullException("connections");
            }
            this.edges = 0;
            this.adj = new List<IList<int>>();
            if (graphType == GraphType.Undirected) {
                this.AddUndirectionEdges(connections);
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
                    "Vertex {0} outside the bounds known vertexes",
                    vertex
                );
                throw new ArgumentException(msg);
            }
            return adj[vertex];
        }

        private void AddDirectedEdges(IList<Tuple<int, int>> connections) {
            foreach (var connection in connections) {
                this.AddEdge(connection.Item1, connection.Item2);
            }
        }

        private void AddUndirectionEdges(IList<Tuple<int, int>> connections) {
            foreach (var connection in connections) {
                this.AddEdge(connection.Item1, connection.Item2);
                this.AddEdge(connection.Item2, connection.Item1);
            }
        }

        private void AddEdge(int origin, int destination) {
            adj[origin].Add(destination);
            edges++;
        }
    }
}
