using System;
using System.Collections;
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


        public void insertNodeAtHead(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
                Console.WriteLine(node.data + "head null");
              //  return node;
            }
            else
            {
                node.next = this.head;

                this.head = node;
                
                
                
                Console.WriteLine(node.data + "head not null");
              //  return temp;
            }
          //  return head;

        }



        public Node insertNodeAtPosition( int data, int position)
        {
            if (position < 1)
            {
                Console.WriteLine("position out of range");

            }
            Node temp = this.head;
                                                       
            while(position -- !=0 && temp != null){
            
                if (position == 1)
                {

                    Node node = new Node(data);
                    node.next = temp.next;
                    temp.next = node;
                    break;

                }
                temp = temp.next;
            }



            return head;
         

        }




    }
}
