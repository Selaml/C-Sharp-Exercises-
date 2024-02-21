using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class singleLinkedLis
    {
     public Node head { get; set; }
  

        public void add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
              this.head = node;
              
            }
            else
            {
                Node temp = this.head;
                while(temp.next != null)
                 {
                     temp = temp.next;
                    

                }
                temp.next = node;

            }
            Console.WriteLine(node.data + "is inserted in the list");
        }

        public void display() {
            if(this.head == null)
            {
                Console.WriteLine("the list is empty");

            }
            else
            {
                Node temp = this.head;
                while(temp != null)
                {
                    Console.WriteLine(temp.data + "are in the list");
                    temp = temp.next;
             
                }

           
            }
          


        }





    }
}
