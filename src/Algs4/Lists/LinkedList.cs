using System;

namespace Algs4.Lists {
    public class LinkedList<T> where T : class {
        private LinkedListNode<T> head;
        private LinkedListNode<T> last;
        private int elements;

        public LinkedListNode<T> First { get { return this.head; } }
        public int Count { get { return this.elements; } }

        public LinkedListNode<T> AddAfter(
            LinkedListNode<T> node,
            LinkedListNode<T> nodeToAdd) {

            if (node == null) {
                throw new ArgumentNullException("node");
            } else if (nodeToAdd == null) {
                throw new ArgumentNullException("nodeToAdd");
            }
            if (node.Next == null) {
                node.Next = nodeToAdd;
            } else {
                nodeToAdd.Next = node.Next;
                node.Next = nodeToAdd;
            }
            if (node == this.last) {
                this.last = nodeToAdd;
            }
            return nodeToAdd;
        }

        public LinkedListNode<T> AddFirst(LinkedListNode<T> node) {
            if (node == null) {
                throw new ArgumentNullException("node");
            }
            if (head == null) {
                head = node;
                last = node;
            } else {
                node.Next = head;
                head = node;
            }
            elements++;
            return this.head;;
        }

        public LinkedListNode<T> AddLast(LinkedListNode<T> node) {
            if (node == null) {
                throw new ArgumentNullException("node");
            }
            if (head == null) {
                head = node;
                last = node;
            } else {
                this.last.Next = node;
                this.last = node;
            }
            elements++;
            return this.last;
        }
    }
}
