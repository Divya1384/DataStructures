using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            var min = new MinHeap(10);
            min.Add(10);
            min.Add(1);
            min.Add(5);
            min.Add(6);
            min.Add(9);
            min.Add(7);
            min.Print();

            min.Peek();
            min.Pop();
            min.Print();

            var max = new MaxHeap(10);
            max.Add(10);
            max.Add(1);
            max.Add(5);
            max.Add(6);
            max.Add(9);
            max.Add(7);
            max.Print();

            max.Peek();
            max.Pop();
            max.Print();

            Console.ReadLine();
        }
    }
}
