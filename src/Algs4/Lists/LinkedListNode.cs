using System;

namespace Algs4.Lists {
    public class LinkedListNode<T> where T : class {
        public T Value { get; set; }
        public LinkedListNode<T> Next {get; set; }

        public LinkedListNode(T val) {
            if (val == null) {
                throw new ArgumentNullException("val");
            }
            this.Value = val;
        }
    }
}
