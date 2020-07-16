using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class MyLinkedList<T>
    {
        public Node First { get; set; }
        public int Count { get; set; }
        public Node Last { get; set; }
        public MyLinkedList()
        {

        }
        public MyLinkedList(IEnumerable<T> enumerable)
        {

        }
        public void AddAfter(Node node, Node newNode)
        {
            Node temp = node;
            newNode.Next = temp;
            node.Next = newNode;
            Count++;
        }
        public void AddAfter(Node node, T value)
        {
            Node newNode = new Node(value);
            Node temp = node;
            newNode.Next = temp;
            node.Next = newNode;
            Count++;
        }
        public void AddBefore(Node node, Node newNode)
        {
            Node temp = node;
            newNode = temp;
            newNode.Next = node;
            Count++;
        }
        public void AddBefore(Node node, T value)
        {
            Node newNode = new Node(value);
            Node temp = node;
            newNode = temp;
            newNode.Next = node;
            Count++;
        }
    }   
}