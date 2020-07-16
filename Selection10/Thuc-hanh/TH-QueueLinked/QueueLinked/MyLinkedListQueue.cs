using System;
using System.Collections.Generic;
using System.Text;

namespace QueueLinked
{
    public class MyLinkedListQueue
    {
        private Node head;
        private Node tail;

        public MyLinkedListQueue()
        {
            this.head = null;
            this.tail = null;
        }
        public void Enqueue(int key)
        {
            Node temp = new Node(key);
            if (this.tail == null)
            {
                this.head = this.tail = temp;
                return;
            }
            this.tail.next = temp;
            this.tail = temp;
        }
        public Node Dequeue()
        {
            if (this.head == null)
                return null;
            Node temp = this.head;
            this.head = this.head.next;
            if (this.head == null)
                this.tail = null;
            return temp;
        }
    }
}
