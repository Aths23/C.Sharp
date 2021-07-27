using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            l.Add("Red");
            l.Add("Blue");
            l.Add("Red");
            l.Add("Red");
            l.Add("Pink");
            l.Add("Yellow");
            l.Add("Green");
            l.Add("Blue");

            Dictionary<string, int> d1 = new Dictionary<string, int>();
            /*d1.Add("Red", 3);
            d1.Add("Blue", 2);
            d1.Add("Pink", 1);
            d1.Add("Yellow", 1);
            d1.Add("Green", 1);*/

            foreach(string color in l)
            {
                if (d1.ContainsKey(color))
                {
                    int curval = d1[color];
                    d1[color] = curval + 1;
                }
                else
                {
                    d1.Add(color, 1);
                }
            }
            
            
            foreach(KeyValuePair<string, int> kvp in d1)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            
        }
    }
}
