using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblem
{
    public class Queue
    {
        Node head = null;
        //Enqueue Method For Inserting A value in Queue
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted to queue", node.data);

        }
        //Display method display the value
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            Console.WriteLine("\nvalue dequeued is {0}", this.head.data);
            this.head = this.head.next;
        }
    }
}
