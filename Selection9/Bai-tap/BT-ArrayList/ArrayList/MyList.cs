using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayLists
{
    public class MyList<T>
    {
        private int capacity;
        private int count;
        private bool isFixedSize;
        private bool isReadOny;
        public int Capacity 
        { 
            get => capacity; 
            set => capacity=value; 
        }
        public int Count
        {
            get => count;
            set => count = value;
        }
        public bool IsFixedSize
        {
            get => isFixedSize;
            set => isFixedSize = value;
        }
        public bool IsReadOny
        {
            get => isReadOny;
            set => isReadOny = value;
        }

        public T[] Items = new T[0];
        public MyList()
        {
            
        }
        public MyList(ICollection collection) 
        {
           
        }
        public MyList(int number)
        {
            Count = number;

        }
        private void EnsureCapacity()
        {
            int newSize = Items.Length+1;
            T[] newArr = new T[newSize];
            for(int i =0; i<Items.Length; i++)
            {
                newArr[i] = Items[i];
            }
            Items = newArr;
            
        }
        public T GetData(int idx)
        {
            if (idx >= Capacity || idx < 0)
            {
                throw new IndexOutOfRangeException("Index: " + idx + ", Capacity: " + Capacity);
            }

            return (T)Items[idx];
        }
        public void Add(T data)
        {
            if (Capacity == Items.Length)
            {
                EnsureCapacity();
            }
            Items[Capacity++] = data;
            Console.WriteLine(Capacity);
        }
        public void AddRange(ICollection collection)
        {
            for (int i = Count; i < Count + collection.Count; i++)
            {
                Add((T)collection.SyncRoot);
            }
        }
        public void Clear()
        {
            Items = new T[0];
        }
        public T[] Clone()
        {
            T[] cloneItems = new T[Items.Length];
            Array.Copy(Items, cloneItems, Items.Length);
            return cloneItems;
        }
        public bool Contains(T data)
        {
            for(int i=0; i < Items.Length; i++)
            {
                if (Items[i].Equals(data))
                {
                    return true;
                }
            }
            return false;
        }
        public T[] CopyTo(T[] arr)
        {
            T[] copyItems = new T[arr.Length];
            Array.Copy(arr, copyItems, arr.Length);
            return copyItems;
        }
        public T[] CopyTo(T[] arr,int index)
        {
            T[] copyItems = new T[arr.Length-index];
            Array.Copy(arr, index, copyItems, arr.Length, arr.Length - index);
            return copyItems;
        }
        public T[] CopyTo(int index, T[] arr, int arr_index,int count)
        {
            T[] copyItems = new T[arr.Length - index];
            Array.Copy(arr, index, copyItems, arr_index, count);
            return copyItems;
        }
        public bool Equals(Object data)
        {
            if(data == this)
            {
                return true;
            }
            return false;
        }
        public int IndexOf(T data)
        {
            for(int i = 0; i < Items.Length; i++)
            {
                if (Items[i].Equals(data))
                {
                    return i;
                }
            }
            return -1;
        }
        public int IndexOf(T data, int index)
        {
            for (int i = index; i < Items.Length; i++)
            {
                if (Items[i].Equals(data))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Insert(int index, T data)
        {
            EnsureCapacity();
            for (int i=index; i < Items.Length - 1; i++)
            {
                Items[i + 1] = Items[i];
            }
            Items[index] = data;
        }
        public void InsertRange(int index, ICollection colection)
        {

        }
        public void RemoveAt(int index)
        {
            for (int i = index; i < Items.Length - 1; i++)
            {
                Items[i] = Items[i+1];
            }
            Array.Resize(ref Items, Items.Length-1);
        }
        public void Remove(T data)
        {
            int index= -1;
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i].Equals(data))
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                for (int i = index; i < Items.Length; i++)
                {
                    Items[i] = Items[i + 1];
                }
                Array.Resize(ref Items, Items.Length - 1);
            }
        }
        public void RemoveRange(int index, int count)
        {
            for (int i = index; i < Items.Length - 1; i++)
            {
                Items[i] = Items[i + count ];
            }
            Array.Resize(ref Items, Items.Length - count);
        }
        public void Reverse()
        {
            int temp = Items.Length - 1;
            for (int i = 0; i < Items.Length/2; i++)
            {
                Items[i] = Items[temp];
                temp--;
            }
        }
        public void Sort()
        {

        }
        public void TrimToSize()
        {
            int count = 0;
            for(int i = Items.Length; i > 0; i--)
            {
                if (Items[Items.Length - 1] == null)
                {
                    count++;
                } else
                {
                    break;
                }
            }
            Array.Resize(ref Items, Items.Length - count);
        }
    }
}
