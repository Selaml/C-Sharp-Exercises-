using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SamsThree
    {
        public  void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var apl = new List<int>();
            var org = new List<int>();
           foreach(int i in apples)
            {
                var bb = a + i;
             
                if(bb>=s&& bb<=t)
                {
                    apl.Add(bb);
                   // Console.WriteLine(apl);
                }
                

            }
            foreach (int j in oranges )
            {
                var cc = b + j;
                if (cc >= s && cc <= t)
                {
                    org.Add(cc);
                   // Console.WriteLine(cc);
                }
              
            }
            Console.WriteLine(apl.Count);
            Console.WriteLine(org.Count);

         

           

        }
    }
}
