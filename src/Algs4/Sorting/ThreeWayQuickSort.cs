using System;
using System.Collections.Generic;

namespace Algs4.Sorting {
    public class ThreeWayQuicksort {
        private static Random random = new Random();

        public static void Sort(IList<IComparable> input) {
            Shuffle(input, random);
            Sort(input, 0, input.Count -1);
        }

        private static void Sort(IList<IComparable> input, int lo, int hi) {
            if (hi <= lo) {
                return;
            }
            var lt = lo;
            var gt = hi;
            var v = input[lo];
            var i = lo;
            while (i <= gt) {
                var cmp = input[i].CompareTo(v);
                if (cmp < 0) {
                    Swap(input, lt++, i++);
                } else if (cmp > 0) {
                    Swap(input, i, gt--);
                } else {
                    i++;
                }
            }
            Sort(input, lo, lt-1);
            Sort(input, gt+1, hi);
        }

        private static void Swap(IList<IComparable> list, int i, int j) {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        private static void Shuffle(IList<IComparable> list, Random rnd) {
            for(var i=0; i < list.Count; i++) {
                Swap(list, i, rnd.Next(i, list.Count));
            }
        }
    }
}
