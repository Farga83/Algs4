using System;
using System.Collections.Generic;
using Algs4.Graphs;
using NUnit.Framework;

namespace Algs4.Tests.Graphs {
    [TestFixture]
    public class GraphTest {

        [Test]
        public void UndirectedCreateIsCorrectlyBuilt() {
            var input = CreateTestInput();
            var g = new Graph(GraphType.Undirected, input, 7);
            Assert.AreEqual(7, g.Vertices());
            Assert.AreEqual(10, g.Edges());
            Assert.AreEqual(3, g.Adjacent(0).Count);
            Assert.AreEqual(1, g.Adjacent(1).Count);
            Assert.AreEqual(2, g.Adjacent(2).Count);
            Assert.AreEqual(1, g.Adjacent(3).Count);
            Assert.AreEqual(0, g.Adjacent(4).Count);
            Assert.AreEqual(2, g.Adjacent(5).Count);
            Assert.AreEqual(1, g.Adjacent(6).Count);
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
