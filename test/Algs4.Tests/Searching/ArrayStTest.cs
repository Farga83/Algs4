using Algs4.Searching;
using NUnit.Framework;

namespace Algs4.Test.Searching {
    [TestFixture]
    public class ArrayStTest {

        [Test]
        public void TestST() {
            var st = new ArraySt<string, string>();
            Assert.AreEqual(0, st.Size());
            Assert.IsTrue(st.IsEmpty());
            st.Put("A", "A");
            Assert.AreEqual(1, st.Size());
            Assert.IsFalse(st.IsEmpty());
            st.Put("B", "B");
            Assert.AreEqual(2, st.Size());
            Assert.IsFalse(st.IsEmpty());
            st.Put("B", "C");
            Assert.AreEqual(2, st.Size());
            Assert.IsFalse(st.IsEmpty());
            st.Delete("B");
            Assert.AreEqual(1, st.Size());
            st.Delete("A");
            Assert.AreEqual(0, st.Size());
            Assert.IsTrue(st.IsEmpty());
        }
    }
}
