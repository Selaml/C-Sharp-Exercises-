using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HourGlass
    {
        public int hourglassSum(List<List<int>> arr)
        {
          //  int sum = 0;
         List<int> a = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                for(int j=0; j < 4 ; j++)
                {
                   int sum = arr[i][j] + arr[i][j+1] + arr[i][j+2] + arr[i+1][j+1] + arr[i + 2][j] + arr[i + 2][j+1]+ arr[i + 2][j + 2];
                   a.Add(sum);
                }
            }
            return a.Max();

        }

    }
}
