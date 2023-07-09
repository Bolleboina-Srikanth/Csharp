using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class Node
    {
        public int data;
        public Node Next;
        public Node(int data)
        {
            this.data = data;
            Next = null;
        }

    }
    public class LinkedList
    {
        Node head;
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if(head==null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while(temp.Next!=null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
            Console.WriteLine($"Element inserted into list: {newNode.data}");
            Console.ReadLine();
        }
        public void Display()
        {
            Node cur = head;
            while (cur != null)
            {
                Console.Write(cur.data + " ");
                cur = cur.Next;
            }
            Console.ReadLine();
        }
       /* static void Main()
        {
            LinkedList l = new LinkedList();
            l.Add(56);
            l.Add(30);
            l.Add(70);
            l.Display();
        }*/
    }

}

