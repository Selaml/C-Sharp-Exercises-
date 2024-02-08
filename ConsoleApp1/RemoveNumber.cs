using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RemoveNumber
    {


        public int[] RemoveNumberArray(int[] stringList,int index)

        {
            Console.WriteLine(stringList[2]);
            int[] result = new int[stringList.Length-1];
          //  List<int> result = new List<int>();
             int count = 0; 
            for(int i=0;i<stringList.Length;i++)
            {
                if (i == index)
                {
                    continue;
                }
               
                result[count++] = stringList[i];

            }
            //Console.WriteLine(result[index]);

            return result;
            

        }
    }
}
