using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT_Code
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    class ListByLinkedList
    {
        // head of linked list
        Node Head, Tail;

        // constructor
        public ListByLinkedList()
        {
            this.Head = null;
            this.Tail = null;
        }

        //Append(A, L) inserts the value A to the end of list L
        public void Append(int value)
        {
            Node node = new Node(value);
            // list empty
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            // list has element
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }
        //Traversing a list in this example: PrintList(L )
        public void PrintList()
        {
            Console.Write("List ");
            Node temp = this.Head;
            while (temp != null)
            {
                Console.Write(temp.data);
                temp = temp.next;
            }
            Console.WriteLine();
        }
        //  Insert(position , X) inserts the value X to list L at position
        //  assumption: the start of the list is position 0
        //  assumption: subsequent elements in the list are shifted out (away from front)
        public bool Insert(int position, int value)
        {
            bool result = false;
            // can insert
            // array still store
            Node node = new Node(value);
            Node temp = Head;
            while (position > 1 && temp != null)
            {
                temp = temp.next;
                position--;
            }
            if (position == 1)
            {
                node.next = temp.next;
                temp.next = node;
                result = true;
            }
            return result;
        }
        //Set(position, Z) updates the value at position 2 to be Z
        //    returns true if position is found, false if position is not found
        public bool Set(int position, int value)
        {
            bool result = false;
            Node temp = this.Head;
            //  can set value
            while (position > 1 && temp != null)
            {
                temp = temp.next;
                position--;
            }
            if (position == 1)
            {
                temp.data = value;
                result = true;
            }
            return result;
        }

        //        Delete(Z) (option 1) removes the first node encountered with value Z
        //          returns the position where the first value is found or list length+1 if not found
        //          assumption: subsequent elements in the list are shifted in (toward front)
        public bool Delete(int value)
        {
            // return when no value 
            bool result = false;
            // scan all elements of list
            Node front = this.Head;
            Node next = front.next;
            if (Head.data == value)
            {
                Head = Head.next;
                result = true;
            }
            else
            {
                while (next != null)
                {
                    if (next.data == value)
                    {
                        front.next = next.next;
                        break;
                    }
                    front = next;
                    next = front.next;
                }
            }
            return result;
        }
        
    }
}
