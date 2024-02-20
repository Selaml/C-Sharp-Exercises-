using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CodeBot
    {

      
        public int findRoom(int [,] rooms)
        {
         
            int sum = 0;
            for (int i = 0; i < rooms.GetLength(0); i++)
            {
                for(int j=0;j< rooms.GetLength(1);j++) {
                    //Console.WriteLine(rooms[i, j] + "tvvv");
                    if (i < rooms.GetLength(0)-1 &&rooms[i, j] == 0 )
                    {
                      /*  Console.WriteLine(i);
                        Console.WriteLine(rooms.GetLength(0)-1 + "this is j");*/
                     
                        rooms[i + 1, j] = 0;
                    }
                    sum = sum + rooms[i, j];
                }
            }
            return sum;

        }
    }
}
