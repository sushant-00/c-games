using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList
    {
        private Node head;
        private Node Tail;

        private int Size;

        public LinkedList()
        {
            this.Size = 0;
        }

        public void InsertFirst(int val)
        {
            Node n1 = new Node(val);
            n1.next = head;
            head = n1;
            if(Tail == null)
            {
                Tail = head;
            }
            Size += 1;
        }

        public void InsertLast(int val)
        {
            if(Tail == null)
            {
                InsertFirst(val);
                return;
            }
            Node n1 = new Node(val);
            Tail.next = n1;
            Tail = n1;
            Size++;

        }


        public void Display()
        {
            Node temp = head;
            while (temp!= null)
            {
                Console.Write(temp.value + "->");
                temp = temp.next;
                

            }
        }

        public void Insert(int val , int index )
        {
            if(index == 0)
            {
                InsertFirst(val);
                return;
            }

            if(index == Size)
            {
                InsertFirst(val);
                return;
            }

            Node temp = head;
            for(int i = 1; i < index; i++)
            {
                temp = temp.next;
            }

            Node n1 = new Node(val , temp.next);
            temp.next = n1;
            Size++;


        }
        private class Node
        {
            public int value;
            public Node next;

            public Node(int _value)
            {
                this.value = _value;
            }

            public Node(int _value , Node n1)
            {
                this.value = _value;
                this.next = n1;

            }


            

        }

    }
}
