using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class rotateArray
    {

        public  List<int> rotateLeft(int d, List<int> arr)
        {
            for (int i = 0; i < d; i++)
            {
                var initalValue = arr[0];
                // List<int> newArray = new List<int>();
arr.RemoveAt(0);
             
                arr.Add(initalValue);

             
            }
            Console.WriteLine(arr[0]);

            return arr;



        }
    }
}
