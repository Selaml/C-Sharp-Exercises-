using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class securityCamera
    {
        public int counttheBoxes(int[,] boxs)
        {
            int count = 0;     
            for(int i = 0;i<boxs.GetLength(0);i++)
            {
                int maxNum;

                for (int j = 0; j < boxs.GetLength(1); j++)
                {
                    if (boxs[i, j] > 1)
                    {

                        int num = boxs[i, j] - 1;
                        Console.WriteLine(num);
                        count = count + num;
                 
                    }
                   
                   
                }
         

            }
            return count;
        }

    }
}
