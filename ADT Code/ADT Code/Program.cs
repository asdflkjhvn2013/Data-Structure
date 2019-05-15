using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueByLinkedList queue = new QueueByLinkedList();
            queue.EnQueue(13);
            queue.PrintList();
            queue.EnQueue(15);
            queue.PrintList();
            queue.EnQueue(12);
            queue.PrintList();
            queue.EnQueue(11);
            queue.PrintList();
            queue.Dequeue();
            queue.PrintList();
            queue.Dequeue();
            queue.PrintList();

            queue.EnQueue(10);
            queue.PrintList();
            queue.EnQueue(18);
            queue.PrintList();

        }
    }
}
