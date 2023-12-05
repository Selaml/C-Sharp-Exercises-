using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class SearchMAtchingStrings
    {
        public  List<int> matchingStrings(List<string> stringList, List<string> queries)
        {
            List<int> result = new List<int>();

            foreach(string  element in queries) {
                if (stringList.Contains(element))
                {



                    var el = (stringList.FindAll(item => item == element)).Count;
                    result.Add(el);
                }
                else
                {
                    result.Add(0);

                }

            }
            Console.WriteLine(result[0]);
            return result;

        }
    }
}
