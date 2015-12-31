using System;

namespace Algs4.Lists {
    public class CycleDetection<T> where T : class {

        public bool HasCycle { get; private set; }
        public LinkedListNode<T> CycleBeginning { get; private set; }

        public CycleDetection(LinkedList<T> list) {
            if (list == null) {
                throw new ArgumentNullException("list");
            }
            this.ProcessList(list);
        }

        private void ProcessList(LinkedList<T> list) {
            var tortoise = list.First;
            var hare = list.First;
            while (hare != null && hare.Next != null) {
                tortoise = tortoise.Next;
                hare = hare.Next.Next;
                if (tortoise == hare) {
                    this.HasCycle = true;
                    this.CycleBeginning = this.CalculateCycleBeginning(
                        list,
                        hare
                    );
                    break;
                }
            }
        }

        private LinkedListNode<T> CalculateCycleBeginning(
            LinkedList<T> list,
            LinkedListNode<T> hare) {
            var tortoise = list.First;
            while (tortoise != hare) {
                tortoise = tortoise.Next;
                hare = hare.Next;
            }
            return tortoise;
        }
    }
}
