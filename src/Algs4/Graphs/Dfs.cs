namespace Algs4.Graphs {
    public class Dfs {

        private bool[] marked;
        private int count;

        public Dfs(Graph graph, int root) {
            this.marked = new bool[graph.Vertices()];
            this.count = 0;
            this.DepthFirstSearch(graph, root);
        }

        public bool Marked(int v) {
            return this.marked[v];
        }

        public int Count() {
            return this.count;
        }

        private void DepthFirstSearch(Graph graph, int vertice) {
            count++;
            marked[vertice] = true;
            foreach (var node in graph.Adjacent(vertice)) {
                if (!marked[node]) {
                    DepthFirstSearch(graph, node);
                }
            }
        }
    }
}
