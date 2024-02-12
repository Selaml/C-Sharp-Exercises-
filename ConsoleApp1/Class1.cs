using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HigestScore
    {
        public List<int> HighScore(List<int> scores)
        {
            List<int> Highresult = new List<int>();
            List<int> LowScore = new List<int>();
            List<int> finalResult = new List<int>();
            int initialElament = scores[0];
            foreach (int i in scores)
            {

                if (i > initialElament && !Highresult.Contains(i))
                {

                    Highresult.Add(i);

                }
                else if (i < initialElament && !LowScore.Contains(i))
                {
                    LowScore.Add(i);

                }
            }

            int high = Highresult.Count();
            int low = LowScore.Count();
            finalResult.Add(high);
            finalResult.Add(low);
            return finalResult;

        }

    }
}
