using System;
using System.Collections.Generic;
using System.Text;

namespace StackArrayList
{
    public class MyStack
    {
        private int[] arr;
        private int size;
        private int index = 0;

        public MyStack(int size)
        {
            this.size = size;
            arr = new int[size];
        }
        public bool IsEmpty()
        {
            if (index == 0)
            {
                return true;
            }
            return false;
        }
        public bool IsFull()
        {
            if (index == size)
            {
                return true;
            }
            return false;
        }
        public int Size()
        {
            return index;
        }
        public void Push(int element)
        {
            if (IsFull())
            {
                throw new Exception("Stack is full");
            }
            arr[index] = element;
            index++;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is null");
            }
            return arr[--index];
        }
    }

}
