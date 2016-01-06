using System;
using System.Collections.Generic;

namespace Algs4.Trees {
    public class Bst<TKey, TValue>
        where TKey : IComparable
        where TValue : class {

        private Node root;

        public void Put(TKey key, TValue val) {
            if (key == null) {
                throw new ArgumentNullException("key");
            } else if (val == null) {
                throw new ArgumentNullException("val");
            }
            root = Put(root, key, val);
        }

        private Node Put(Node node, TKey key, TValue val) {
            if (node == null) {
                return new Node { Key = key, Value = val };
            }
            var cmp = key.CompareTo(node.Key);
            if (cmp < 0) {
                node.Left = Put(node.Left, key, val);
            } else if (cmp > 0) {
                node.Right = Put(node.Right, key, val);
            } else {
                node.Value = val;
            }
            return node;
        }

        public TValue Get(TKey key) {
            if (key == null) {
                throw new ArgumentNullException("key");
            }
            return Get(root, key);
        }

        public IEnumerable<TValue> PreOrderTraversal() {
            return PreOrderTraversal(root);
        }

        public IEnumerable<TValue> InorderTraversal() {
            return InorderTraversal(root);
        }

        public IEnumerable<TValue> PostOrderTraversal() {
            return PostOrderTraversal(root);
        }

        private IEnumerable<TValue> PostOrderTraversal(Node node) {
            var values = new List<TValue>();
            if (node != null) {
                values.AddRange(PostOrderTraversal(node.Left));
                values.AddRange(PostOrderTraversal(node.Right));
                values.Add(node.Value);
            }
            return values;
        }

        private IEnumerable<TValue> PreOrderTraversal(Node node) {
            var values = new List<TValue>();
            if (node != null) {
                values.Add(node.Value);
                values.AddRange(PreOrderTraversal(node.Left));
                values.AddRange(PreOrderTraversal(node.Right));
            }
            return values;
        }

        private IEnumerable<TValue> InorderTraversal(Node node) {
            var values = new List<TValue>();
            if (node != null) {
                values.AddRange(InorderTraversal(node.Left));
                values.Add(node.Value);
                values.AddRange(InorderTraversal(node.Right));
            }
            return values;
        }

        private TValue Get(Node node, TKey key) {
            if (node == null) {
                return null;
            }
            var cmp = key.CompareTo(node.Key);
            if (cmp < 0) {
                return Get(node.Left, key);
            } else if (cmp > 0) {
                return Get(node.Right, key);
            } else {
                return node.Value;
            }
        }

        private class Node {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }
    }
}
