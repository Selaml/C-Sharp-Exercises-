using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class kangaroo
    {
        public string kangaroodist(int x1, int v1, int x2, int v2)
        {
            //int total =  x1 + v1; ;
            //int total2 = x2 + v2; ;

            int k1 = x1 + v1;
            int k2 = x2 + v2;
            if (x1 > x2 && v1 > v2 || x1 < x2 && v1 < v2)
            {
                return "NO";

            }
            else if(k1==k2)
            {
                return "YES";
            }
            else { 
            


                for (int j = 1; j < 1000000; j++)
                {

                    k1 = k1 + v1;

                    k2 = k2 + v2;


                    if (k1 == k2)
                    {
                        return "YES";
                    }

                }







                return "NO";
            }
        }


    }
}
