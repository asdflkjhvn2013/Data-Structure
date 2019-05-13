using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT_Code
{
    class ListByArray
    {
        // array store data
        int[] data;
        // located in array to next value
        int index;

        // constructor
        public ListByArray(int size)
        {
            data = new int[size];
            index = 0;

        }
        //Append(A, L) inserts the value A to the end of list L
        public bool Append(int value)
        {
            bool result = false;
            // array can store value
            if (index <= data.Length)
            {
                // store value
                data[index] = value;
                // increment index
                index++;
                // store success
                result = true;
            }
            else
            {
                // store fail
                // array full
                // some algorithm to change array size
            }
            return result;
        }
        //  Insert(position , X) inserts the value X to list L at position
        //  assumption: the start of the list is position 0
        //  assumption: subsequent elements in the list are shifted out (away from front)
        public bool Insert(int position, int value)
        {
            bool result = false;
            // can insert
            // array still store
            if (index < data.Length)
            {
                // 
                if (position <= index)
                {
                    // shift all value from position
                    for (int i = index; i >= position; i--)
                    {
                        data[i] = data[i - 1];
                    }
                    // store value to position
                    data[position] = value;
                    index++;
                    result = true;
                }
                else
                {
                    // positon out of range
                }
            }
            else
            {
                // array is full
            }
            return result;
        }
        //Set(position, Z) updates the value at position 2 to be Z
        //    returns true if position is found, false if position is not found
        public bool Set(int position, int value)
        {
            bool result = false;
            //  can set value
            if (position <= index)
            {
                data[position] = value;
                result = true;
            }
            else
            {
                //  not set value
            }
            return result;
        }

        //        Remove(Z) (option 1) removes the first node encountered with value Z
        //          returns the position where the first value is found or list length+1 if not found
        //          assumption: subsequent elements in the list are shifted in (toward front)
        public int Remove(int value)
        {
            // return when no value 
            int position = -1;
            // scan all elements of list
            for (int i = 0; i < index; i++)
            {
                // found value
                if (data[i] == value)
                {
                    // shift elements to head
                    for (int j = i; j < index; j++)
                    {
                        data[j] = data[j + 1];
                    }
                    // reduce index
                    index--;
                    // locate of value
                    position = i;
                    // escape loop
                    break;
                }
            }
            return position;
        }
        //RemoveAll(Z) (option 2) removes all nodes with the value Z
        //    returns the number of elements removed, 0 indicates none were found
        //    assumption: subsequent elements in the list are shifted in (toward front)
        public int RemoveAll(int value)
        {
            // return when no value 
            int count = 0;
            // scan all elements of list
            for (int i = 0; i < index; i++)
            {
                // found value
                if (data[i] == value)
                {
                    // shift elements to head
                    for (int j = i; j < index; j++)
                    {
                        data[j] = data[j + 1];
                    }
                    // reduce index
                    index--;
                    // increase of value
                    count++;
                }
            }
            return count
;
        }

        //Remove(position) (option 3) removes node one regardless of value
        //    returns true if position is found, false if position is not found

        public bool RemovePos(int position)
        {
            bool result = false;
            if (position < index)
            {
                for (int i = position; i < index; i++)
                {
                    data[i] = data[i + 1];
                }
                result = true;
            }
            return result;
        }

        //Get(position) returns the value of the third node

        public int Get(int position)
        {
            // position belongs list range 
            if (position >= 0 && position < index)
            {
                return data[position];
            }
            else
            {
                return int.MaxValue;
            }
        }

        //Find(X) returns the index of the node with value X
        public int Find(int value)
        {
            // position return when no value
            int position = -1;
            // scan all elements
            for (int i = 0; i < index; i++)
            {
                // found value
                if (data[i] == value)
                {
                    // position of value
                    position = i;
                    // escape loop

                    break;
                }
            }
            return position;
        }

        //Swap(pos1,pos2) exchanges the values at index pos1 with pos2

        public bool Swap(int position1, int position2)
        {
            bool result = false;
            if (position1 >= 0 &&
                position2 >= 0 &&
                position1 < index &&
                position2 < index)
            {
                int temp = data[position1];
                data[position1] = data[position2];
                data[position2] = temp;
                result = true;
            }
            return result;
        }
    }
}
