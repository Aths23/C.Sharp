using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add("Atharva");
            Console.WriteLine(al.Capacity);
            al.Add("Yugendra");
            al.Add("Kartik");
            al.Add("Gautam");
            al.Add("Kunal");
            al.Add("Rohan");
            al.Sort();

            foreach(var x in al)
                Console.WriteLine(x);
            
        }
    }
}
