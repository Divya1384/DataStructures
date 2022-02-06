using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dequeue
{
    class Program
    {
        static void Main(string[] args)
        {
            Dequeue dequeue = new Dequeue(10);
            dequeue.InsertAtFront(5);
            dequeue.InsertAtFront(10);
            dequeue.InsertAtFront(15);
            dequeue.InsertAtFront(20);
            dequeue.InsertAtFront(25);
            dequeue.InsertAtFront(30);
            dequeue.InsertAtFront(35);
            dequeue.InsertAtFront(40);
            dequeue.InsertAtFront(45);
            dequeue.InsertAtFront(50);

            Console.WriteLine($"Dequeue values: Front - {dequeue.front} Rear - {dequeue.rear} - {dequeue.GetFront()} - {dequeue.GetRear()}");
            Console.WriteLine($"{dequeue.array[0]}");
            Console.WriteLine($"{dequeue.array[1]}");
            Console.WriteLine($"{dequeue.array[2]}");
            Console.WriteLine($"{dequeue.array[3]}");
            Console.WriteLine($"{dequeue.array[4]}");
            Console.WriteLine($"{dequeue.array[5]}");
            Console.WriteLine($"{dequeue.array[6]}");
            Console.WriteLine($"{dequeue.array[7]}");
            Console.WriteLine($"{dequeue.array[8]}");
            Console.WriteLine($"{dequeue.array[9]}");
            Console.Read();
        }
    }
}
