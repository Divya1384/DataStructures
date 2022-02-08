using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class MinHeap
    {
        private static int _minsize = 0;
        private int[] _array;

        public MinHeap(int capacity)
        {
            _array = new int[capacity];
        }

        private int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
        private int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;
        private int GetParentIndex(int elementIndex) => (elementIndex - 1) / 2;

        private bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < _minsize;
        private bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < _minsize;
        private bool IsRoot(int elementIndex) => elementIndex == 0;

        private int GetLeftChild(int elementIndex) => _array[GetLeftChildIndex(elementIndex)];
        private int GetRightChild(int elementIndex) => _array[GetRightChildIndex(elementIndex)];
        private int GetParent(int elementIndex) => _array[GetParentIndex(elementIndex)];

        private bool IsEmpty() => _minsize == 0;

        private void Swap(int firstIndex, int secondIndex)
        {
            int temp = _array[firstIndex];
            _array[firstIndex] = _array[secondIndex];
            _array[secondIndex] = temp;
        }

        private void RecalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                int smallestIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index) < GetLeftChild(index))
                {
                    smallestIndex = GetRightChildIndex(index);
                }

                if (_array[index] <= _array[smallestIndex]) break;

                Swap(index, smallestIndex);

                index = smallestIndex;
            }
        }

        private void RecalculateUp()
        {
            int index = _minsize - 1;

            while (!IsRoot(index) && _array[index] < GetParent(index))
            {
                int parentIndex = GetParentIndex(index);
                Swap(index, parentIndex);
                index = parentIndex;
            }
        }

        public int Peek()
        {
            if (IsEmpty()) throw new IndexOutOfRangeException();
            return _array[0];
        }

        public int Pop()
        {
            if (IsEmpty()) throw new IndexOutOfRangeException();
            int result = _array[0];
            _array[0] = _array[_minsize - 1];
            _minsize--;
            RecalculateDown();
            return result;
        }

        public void Add(int element)
        {
            if (_minsize == _array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            _array[_minsize] = element;
            _minsize++;
            RecalculateUp();
        }

        public void Print()
        {
            for (int i = 0; i < _minsize; i++)
            {
                Console.Write(_array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
