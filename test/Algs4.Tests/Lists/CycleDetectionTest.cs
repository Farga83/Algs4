using System;
using Algs4.Lists;
using NUnit.Framework;

 namespace Algs4.Tests.Lists {
    [TestFixture]
    public class CycleDetectionTest {

        [Test]
        public void NoCycle() {
            var list = new LinkedList<string>();
            var first = list.AddFirst(new LinkedListNode<string>("first"));
            list.AddAfter(first, new LinkedListNode<string>("second"));
            var second = first.Next;
            list.AddAfter(second, new LinkedListNode<string>("third"));
            var detection = new CycleDetection<string>(list);
            Assert.That(detection.HasCycle, Is.False);
        }

        [Test]
        public void Cycle() {
            var list = new LinkedList<string>();
            var first = list.AddFirst(new LinkedListNode<string>("first"));
            list.AddAfter(first, new LinkedListNode<string>("second"));
            list.AddLast(first);
            var detection = new CycleDetection<string>(list);
            Assert.That(detection.HasCycle, Is.True);
        }

        [Test]
        public void CycleDetectStartElement() {
            var list = new LinkedList<string>();
            var first = list.AddFirst(new LinkedListNode<string>("first"));
            var second = list.AddAfter(
                first,
                new LinkedListNode<string>("second")
            );
            list.AddAfter(
                second,
                new LinkedListNode<string>("third")
            );
            list.AddLast(second);
            var detection = new CycleDetection<string>(list);
            Assert.That(detection.CycleBeginning, Is.EqualTo(second));
        }
    }
 }
