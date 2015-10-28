using System.Collections.Generic;
using System.Linq;

namespace Algs4.Searching {
    public class ArraySt<T, U> where T : class  where U : class {
        private T[] keys;
        private U[] values;
        private int elements;

        public ArraySt() {
            keys = new T[10];
            values = new U[10];
            elements = 0;
        }

        public void Put(T key, U val) {
            if (elements == keys.Length) {
                //resize the arrays and copy
            }
            var index = GetKeyIndex(key);
            if (index == -1) {
                keys[elements] = key;
                values[elements] = val;
                elements++;
            } else {
                values[index] = val;
            }
        }

        public U Get(T key) {
            var index = GetKeyIndex(key);
            if (index > -1) {
                return values[index];
            } else {
                return null;
            }
        }

        public void Delete(T key) {
            var index = GetKeyIndex(key);
            if (index != -1) {
                keys[index] = keys[elements-1];
                values[index] = values[elements-1];
                keys[elements-1] = null;
                values[elements-1] = null;
                elements--;
            }
        }

        public bool Contains(T key) {
            return GetKeyIndex(key) != -1;
        }

        public bool IsEmpty() {
            return elements == 0;
        }

        public int Size() {
            return elements;
        }

        public IEnumerable<T> Keys() {
            return keys.AsEnumerable();
        }

        private int GetKeyIndex(T key) {
            for (var i = 0; i < elements; i++) {
                if (keys[i].Equals(key)) {
                    return i;
                }
            }
            return -1;
        }
    }
}
