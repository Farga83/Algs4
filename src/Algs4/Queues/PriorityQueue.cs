using System;
using System.Collections;

namespace Algs4.Queues {
    public class PriorityQueue<T> where T : class, IComparable {
        private T[] heap;
        private int currentIndex;
        private IComparer comparer;


        //Need to make this a resizing array and also use the passed in
        //comparer so the class can be both max or min based.
        public PriorityQueue(int initialSize, IComparer comparer) {
            this.heap = new T[initialSize+1];
            this.currentIndex = 0;
            this.comparer = comparer;
        }

        public void Enqueue(T element) {
            this.heap[++currentIndex] = element;
            this.Swim(currentIndex);
        }

        public T Dequeue() {
            var temp = this.heap[1];
            this.heap[1] = this.heap[currentIndex];
            this.heap[currentIndex] = null;
            currentIndex--;
            this.Sink(1);
            return temp;
        }

        private void Sink(int position) {
            while (2*position <= currentIndex) {
                var largest = position*2;
                if (largest < currentIndex && this.Less(largest, largest+1)) {
                    largest++;
                }
                if (this.Less(position, largest)) {
                    this.Swap(position, largest);
                    position = largest;
                }
            }
        }

        private void Swim(int position) {
            while (position > 1 && this.Less(position/2, position)) {
                this.Swap(position, position/2);
                position = position/2;
            }
        }

        private void Swap(int firstPosition, int secondPosition) {
            var temp = this.heap[firstPosition];
            this.heap[firstPosition] = this.heap[secondPosition];
            this.heap[secondPosition] = temp;
        }

        private bool Less(int first, int second) {
            return this.heap[first].CompareTo(this.heap[second]) == -1;
        }
    }
}
