using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Riverse
    {
        public  List<int> reverseArray(List<int> a)
        {
            List<int> list = new List<int>();
            // a.Reverse();
            for (int i = a.Count-1 ; i >=0; i--)
            {
             

                    list.Add(a[i]);
               
               
            }

            return list;

        }

    }
}
