using System.Collections.Generic;
using System.Linq;
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

        [Test]
        public void InorderTraversal() {
            var bst = new Bst<string, string>();
            bst.Put("f", "f");
            bst.Put("b", "b");
            bst.Put("g", "g");
            bst.Put("a", "a");
            bst.Put("d", "d");
            bst.Put("i", "i");
            bst.Put("c", "c");
            bst.Put("e", "e");
            bst.Put("h", "h");
            var values = bst.InorderTraversal().ToList();
            Assert.That(values.Count, Is.EqualTo(9));
            Assert.That(values[0], Is.EqualTo("a"));
            Assert.That(values[1], Is.EqualTo("b"));
            Assert.That(values[2], Is.EqualTo("c"));
            Assert.That(values[3], Is.EqualTo("d"));
            Assert.That(values[4], Is.EqualTo("e"));
            Assert.That(values[5], Is.EqualTo("f"));
            Assert.That(values[6], Is.EqualTo("g"));
            Assert.That(values[7], Is.EqualTo("h"));
            Assert.That(values[8], Is.EqualTo("i"));
        }

        [Test]
        public void PreOrderTraversal() {
            var bst = new Bst<string, string>();
            bst.Put("f", "f");
            bst.Put("b", "b");
            bst.Put("g", "g");
            bst.Put("a", "a");
            bst.Put("d", "d");
            bst.Put("i", "i");
            bst.Put("c", "c");
            bst.Put("e", "e");
            bst.Put("h", "h");
            var values = bst.PreOrderTraversal().ToList();
            Assert.That(values.Count, Is.EqualTo(9));
            Assert.That(values[0], Is.EqualTo("f"));
            Assert.That(values[1], Is.EqualTo("b"));
            Assert.That(values[2], Is.EqualTo("a"));
            Assert.That(values[3], Is.EqualTo("d"));
            Assert.That(values[4], Is.EqualTo("c"));
            Assert.That(values[5], Is.EqualTo("e"));
            Assert.That(values[6], Is.EqualTo("g"));
            Assert.That(values[7], Is.EqualTo("i"));
            Assert.That(values[8], Is.EqualTo("h"));
        }

        [Test]
        public void PostOrderTraversal() {
            var bst = new Bst<string, string>();
            bst.Put("f", "f");
            bst.Put("b", "b");
            bst.Put("g", "g");
            bst.Put("a", "a");
            bst.Put("d", "d");
            bst.Put("i", "i");
            bst.Put("c", "c");
            bst.Put("e", "e");
            bst.Put("h", "h");
            var values = bst.PostOrderTraversal().ToList();
            Assert.That(values.Count, Is.EqualTo(9));
            Assert.That(values[0], Is.EqualTo("a"));
            Assert.That(values[1], Is.EqualTo("c"));
            Assert.That(values[2], Is.EqualTo("e"));
            Assert.That(values[3], Is.EqualTo("d"));
            Assert.That(values[4], Is.EqualTo("b"));
            Assert.That(values[5], Is.EqualTo("h"));
            Assert.That(values[6], Is.EqualTo("i"));
            Assert.That(values[7], Is.EqualTo("g"));
            Assert.That(values[8], Is.EqualTo("f"));
        }
    }
}
