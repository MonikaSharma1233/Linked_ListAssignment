using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    internal class LinkedList
    {

        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data); ;
            if (this.head == null)
            {
                this.head = node;
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
            Console.WriteLine("{0} The data is inserted.", node.data);
        }

        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position.");
            }

           if (position == 0)
            {
                Console.WriteLine("position out of range");
            }
            if (head == null)
            {
                var newnode = new Node(data);
                head = newnode;
                Console.WriteLine("Inserted element " + head.data + " on position " + position);
            }
            if (position == 1)
            {
                Node temp = head;
                Node newnode = new Node(data);
                head = newnode;
                newnode.next = temp;
            }
            else
            {
                int counter = 0;
                Node temp = head;
                //position=2,data=30
                while (counter == position-1)
                {
                    
                    temp = temp.next;
                    counter++;
               
                }
              
                Node newnode = new Node(data);
                if(temp==null || temp.next==null)
                {
                    temp = newnode;
                    
                }
                else
                {
                    newnode.next = temp.next;
                    temp.next = newnode;
                }
                //newnode = temp;
               // temp.next = newnode;
                Console.WriteLine("Inserted element " + newnode.data + " on position " + position);
            }

            return head;
        }
        internal Node Pop()
        {
            if (head == null)
            {
                Console.WriteLine("No nodein linkedlist");
            }
            else if (head.next == null)
            {
                Node temp1;
                temp1 = head;
                head = null;
            }
            else
            {
                Node temp = head;
                head = temp.next;
            }

            return head;
        }
        internal Node PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty ,No element");
            }
            else if (head.next == null)
            {
                Node temp;
                temp = head;//for backup purpose
                head = null;
            }
            else
            {
                Node temp;
                temp = head;//for pointer purpose
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Node backupnode;
                backupnode = temp;//for backup purpose
                temp.next = null;

            }
            return head;
        }

        internal int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count + 1;
                }
                node = node.next;
                count++;
            }
            return count + 1;
        }
        public void DeleteNodeAtParticularPosition(int position)
        {
            
            int count = 0;
            
            if (this.head == null)
            {
                Console.WriteLine("List is empty ,No element");
                return;
            }
            Node temp = this.head;
            if (position==null)
            {
                this.head = temp.next;
                return;
            }
            else
            {
                while(count<position-1)
                {
                    temp = temp.next;
                    count++;
                }
                int item = temp.next.data;
                temp.next = (temp.next).next;
                Console.WriteLine("The node " + item + "is deleted at position: " +position);
            }
            

        }
        internal int[] Sortedarrayreturn()
        {
            int sizeoflist = 0;
            Node temp= this.head;
            int[] sortingarray = new int[sizeoflist];
            while (temp != null)
            {
                temp = temp.next;
                sizeoflist++;
                sortingarray = new int[sizeoflist];
                for(int i=0;i<sizeoflist; i++)
                {
                    sortingarray[i] = temp.data;
                }
                
            }
            return sortingarray;
        }
        internal void Sortedlist()
        {
            int[] arr = Sortedarrayreturn();
            int backup=0;
            
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        backup = arr[i];
                        arr[i]= arr[j];
                        arr[j]= backup;
                    }
                }
            }
            Console.WriteLine("The Sorted Linked List is : \n");
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine(arr[i]);
            }
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("The Linked List is Empty.");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }

        }

    }
}
