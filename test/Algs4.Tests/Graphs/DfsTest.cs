using System;
using System.Collections.Generic;
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

        private IList<Tuple<int, int>> CreateTestInput() {
            return new List<Tuple<int, int>> {
                Tuple.Create(0,2),
                Tuple.Create(0,3),
                Tuple.Create(0,5),
                Tuple.Create(2,5),
                Tuple.Create(1,6)
            };
        }
    }
}
