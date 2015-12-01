using System;

namespace Algs4.Trees {
    public class BST<Key, Value> where Key : IComparable {

        private Node<Key, Value> root;

        public void Put(Key key, Value val) {

        }

        public Value Get(Key key) {
            return default(Value) ;
        }

        private class Node<Key, Value> {
            Key key;
            Value value;
            Node<Key, Value> left, right;
        }
    }
}
