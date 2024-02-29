using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StackUsingArrays
    {
        public int top  {get;set;}
        int [] arr= new int[5];

      /*  public StackUsingArrays(int peak, int[] arrayData)
        {

            top = peak;
            arr = arrayData;
        }*/

         public void push(int data)
            {

            arr[top] = data;

            Console.WriteLine(arr[top]);
            top = top + 1;


            Console.WriteLine(top);
            foreach (int i in arr)
            {

                Console.WriteLine(i);
            }

        }
        public void pop()
        {

            
           
            top = top - 1;


            Console.WriteLine(top);
            foreach (int i in arr) {


                Console.WriteLine(i);
            }

        }
    
    }
}
