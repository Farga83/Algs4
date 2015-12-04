using NUnit.Framework;
using Algs4.Trees;

namespace Algs4.Tests.Trees {
    [TestFixture]
    public class BstTest {

        [Test]
        public void GetNotAddedReturnsNull() {
            var bst = new Bst<string, string>();
            var val = bst.Get("test");
            Assert.That(val, Is.Null);
        }

        [Test]
        public void PutDoesntThrow() {
            var bst = new Bst<string, string>();
            Assert.That(() => bst.Put("test", "v1"), Throws.Nothing);
        }

        [Test]
        public void PutThenGetGetValue() {
            var bst = new Bst<string, string>();
            bst.Put("test", "v1");
            var foundValue = bst.Get("test");
            Assert.That(foundValue, Is.EqualTo("v1"));
        }

        [Test]
        public void PutKeyTwiceGetNewValue() {
            var bst = new Bst<string, string>();
            bst.Put("test", "v1");
            bst.Put("test", "v2");
            var foundValue = bst.Get("test");
            Assert.That(foundValue, Is.EqualTo("v2"));
        }
    }
}
