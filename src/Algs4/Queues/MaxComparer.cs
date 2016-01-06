using System;
using System.Collections;

namespace Algs4.Queues {
    public class MaxComparer<T> : IComparer
        where T : class, IComparable {

        public int Compare(Object x, Object y) {
            if (x == null) {
                return -1;
            } else if (y == null) {
                return 1;
            } else {
                return (x as T).CompareTo(y as T);
            }
        }
    }
}
