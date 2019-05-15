using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT_Code
{
    class QueueByArray
    {
        int[] data;
        int front, rear;
        public QueueByArray(int size)
        {
            data = new int[size];
            this.front = -1;
            this.rear = -1;
        }
        public bool EnQueue(int value)
        {
            bool result = false;
            // empty queue
            if (front == -1)
            {
                front = 0;
                rear = 0;
                data[front] = value;
            }
            else
            {
                if ((front + 1) % data.Length == rear)
                {

                }
            }
            return result;
        }

    }
}
