using System;

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
