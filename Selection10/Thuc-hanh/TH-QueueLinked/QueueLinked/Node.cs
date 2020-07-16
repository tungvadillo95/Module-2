using System;
using System.Collections.Generic;
using System.Text;

namespace QueueLinked
{
    public class Node
    {
        public int key;
        public Node next;

        public Node(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
}
