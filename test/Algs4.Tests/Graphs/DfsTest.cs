using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Algs4.Graphs;

namespace Algs4.Tests.Graphs {
    [TestFixture]
    public class DfsTest {

        [Test]
        public void UndirectedConnectionsAreMarked() {
            var input = CreateTestInput();
            var g = new Graph(GraphType.Undirected, input, 7);
            var search = new Dfs(g, 0);
            Assert.IsTrue(search.Marked(2));
            Assert.IsTrue(search.Marked(3));
            Assert.IsTrue(search.Marked(5));
            Assert.IsFalse(search.Marked(1));
            Assert.IsFalse(search.Marked(4));
            Assert.IsFalse(search.Marked(6));

        }

        [Test]
        public void UndirectedHasPathToAreCorrect() {
            var input = CreateTestInput();
            var g = new Graph(GraphType.Undirected, input, 7);
            var search = new Dfs(g, 0);
            Assert.IsTrue(search.HasPathTo(2));
            Assert.IsTrue(search.HasPathTo(3));
            Assert.IsTrue(search.HasPathTo(5));
            Assert.IsFalse(search.HasPathTo(0)); // No path to self
            Assert.IsFalse(search.HasPathTo(1));
            Assert.IsFalse(search.HasPathTo(4));
            Assert.IsFalse(search.HasPathTo(6));
        }

        [Test]
        public void UndirectedPathToFiveHasToVertices() {
            var input = CreateTestInput();
            var g = new Graph(GraphType.Undirected, input, 7);
            var search = new Dfs(g, 0);
            var path = search.PathTo(5).ToArray();
            Assert.AreEqual(2, path.Length);
            Assert.AreEqual(2, path[0]);
            Assert.AreEqual(5, path[1]);
        }

        private IList<Tuple<int, int>> CreateTestInput() {
            return new List<Tuple<int, int>> {
                Tuple.Create(0,2),
                Tuple.Create(2,5),
                Tuple.Create(0,3),
                Tuple.Create(0,5),
                Tuple.Create(1,6)
            };
        }
    }
}
