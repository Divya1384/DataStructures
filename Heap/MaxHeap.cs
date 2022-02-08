using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class MaxHeap
    {
        private static int _maxsize = 0;
        private int[] _array;

        public MaxHeap(int capacity)
        {
            _array = new int[capacity];
        }
        
        private int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
        private int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;
        private int GetParentIndex(int elementIndex) => (elementIndex - 1) / 2;

        private bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < _maxsize;
        private bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < _maxsize;
        private bool IsRoot(int elementIndex) => elementIndex == 0;

        private int GetLeftChild(int elementIndex) => _array[GetLeftChildIndex((elementIndex))];
        private int GetRightChild(int elementIndex) => _array[GetRightChildIndex((elementIndex))];
        private int GetParent(int elementIndex) => _array[GetParentIndex(elementIndex)];

        private bool IsEmpty() => _maxsize == 0;

        private void Swap(int firstIndex, int secondIndex)
        {
            var temp = _array[firstIndex];
            _array[firstIndex] = _array[secondIndex];
            _array[secondIndex] = temp;
        }

        public int Peek()
        {
            if (_maxsize == 0)
            {
                throw new IndexOutOfRangeException();
            }

            return _array[0];
        }

        public int Pop()
        {
            if (_maxsize == 0)
            {
                throw new IndexOutOfRangeException();
            }

            int result = _array[0];
            _array[0] = _array[_maxsize - 1];
            _maxsize--;

            RecalculateDown();
            return result;
        }

        public void Add(int key)
        {
            if (_maxsize == _array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            _array[_maxsize] = key;
            _maxsize++;

            RecalculateUp();
        }

        private void RecalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                int largestIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetLeftChild(index) < GetRightChild(index))
                {
                    largestIndex = GetRightChildIndex((index));
                }

                if (_array[largestIndex] <= _array[index]) break;

                Swap(largestIndex, index);
                index = largestIndex;
            }
        }

        private void RecalculateUp()
        {
            int index = _maxsize - 1;
            while (!IsRoot(index) && _array[index] > GetParent(index))
            {
                int parentIndex = GetParentIndex(index);
                Swap(index, parentIndex);
                index = parentIndex;
            }
        }

        public void Print()
        {
            for (int i = 0; i < _maxsize; i++)
            {
                Console.Write(_array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
