using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT_Code
{
    class QNode
    {
        public int data;
        public QNode next;

        public QNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    class QueueByLinkedList
    {
        QNode front, rear;

        public QueueByLinkedList()
        {
            this.front = null;
            this.rear = null;
        }
        //Enqueuing a data item on to the queue:
        public void EnQueue(int value)
        {
            QNode node = new QNode(value);

            if (front == null)
            {
                front = node;
                rear = node;
            }
            else
            {
                rear.next = node;
                rear = node;
            }
        }
        //Dequeuing a data item on to the queue:
        public int Dequeue()
        {
            int value = int.MaxValue;
            if (front != null)
            {
                value = front.data;
                front = front.next;
            }
            else
            {
                // Queue underflow
            }
            return value;
        }

        public int Peek()
        {
            // value return when queue empty
            int value = int.MaxValue;
            if (front != null)
            {
                value = front.data;                
            }
            else
            {
                // Queue underflow
            }
            return value;
        }
        // number of element in queue
        public int NumElements()
        {
            int num = 0;
            QNode temp = front;
            while (temp != null)
            {
                num++;
                temp = temp.next;
            }
            return num;
        }

        public void PrintList()
        {
            QNode temp = front;
            Console.Write(" Queue ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
