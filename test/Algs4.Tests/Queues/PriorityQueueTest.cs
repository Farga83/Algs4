using Algs4.Queues;
using NUnit.Framework;

namespace Algs4.Tests.Queues {
    [TestFixture]
    public class PriorityQueueTest {

        [Test]
        public void ConstructorDoesntThrow() {
            Assert.DoesNotThrow(() => new PriorityQueue<string>(10, new MaxComparer<string>()));
        }
    }
}
