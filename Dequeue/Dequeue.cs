using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dequeue
{
    public class Dequeue
    {
        public int[] array;
        public int front;
        public int rear;
        int size;

        public Dequeue(int size)
        {
            array = new int[10];
            front = -1;
            rear = 0;
            this.size = size;
        }

        public bool IsFull()
        {
            return ((front == 0 && rear == size - 1) || front == rear + 1);
        }

        public bool IsEmpty()
        {
            return (front == -1);
        }

        /// <summary>
        /// Will be inserted in reverse order except the first value inserted
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void InsertAtFront(int value)
        {
            CheckDuringInsert(out bool isFull, out bool isEmpty);

            if (isFull) return;
            if (!isEmpty)
            {
                if (front == 0)
                {
                    front = size - 1;
                }
                else
                {
                    front--;
                }
            }
            array[front] = value;
        }

        /// <summary>
        /// Will be inserted in the same order
        /// </summary>
        /// <param name="value"></param>
        public void InsertAtRear(int value)
        {
            CheckDuringInsert(out bool isFull, out bool isEmpty);

            if (isFull) return;
            if (!isEmpty)
            {
                if (rear == size - 1)
                {
                    rear = 0;
                }
                else
                {
                    rear++;
                }
            }
            array[rear] = value;
        }

        public void DeleteFromFront()
        {
            CheckDuringDelete(out bool isEmpty, out bool hasOneElement);

            if (isEmpty) return;
            if (!hasOneElement)
            { 
                if (front == size - 1)
                {
                    front = 0;
                }
                else
                {
                    front++;
                }
            }
        }

        public void DeleteFromRear()
        {
            CheckDuringDelete(out bool isEmpty, out bool hasOneElement);

            if (isEmpty) return;
            if (!hasOneElement)
            {
                if (rear == 0)
                {
                    rear = size - 1;
                }
                else
                {
                    rear--;
                }
            }
        }

        public int GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue underflow");
                return 0;
            }

            return array[front];
        }

        public int GetRear()
        {
            if (IsEmpty() || rear < 0)
            {
                Console.WriteLine("Queue underflow");
                return 0;
            }
            return array[rear];
        }

        private void CheckDuringDelete(out bool isEmpty, out bool hasOneElement)
        {
            isEmpty = false;
            hasOneElement = false;
            if (IsEmpty())
            {
                Console.WriteLine("Queue underflow");
                isEmpty = true;
            }

            if (front == rear)
            {
                front = -1;
                rear = -1;
                hasOneElement = true;
            }
        }

        private void CheckDuringInsert(out bool isFull, out bool isEmpty)
        {
            isFull = false;
            isEmpty = false;
            if (IsFull())
            {
                Console.WriteLine("Queue overflow");
                isFull = true;
            }

            if (front == -1)
            {
                front = 0;
                rear = 0;
                isEmpty = true;
            }
        }
    }
}
