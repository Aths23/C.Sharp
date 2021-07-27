using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections.Delegates
{
    delegate void mydelegate(string m);
    delegate void mydelegate1(int a, int b);
    delegate int delFact(int n);
    delegate bool delEven(int o);
  
    class Class1
    {
        static void name(string m)
        {
            Console.WriteLine("My Name is "+m);
        }
        static int Fact(int x)
        {
            int f = 1;
            for(int i=2; i <= x; i++)
            {
                f = f * 1;
            }
            return f;
        }
        static bool Even(int o)
        {
            return o % 2 == 0;
        }
        static void M1(mydelegate1 callback)
        {
            callback(2, 3);
        }
        static void Main(string[] args)
        {
            //mydelegate ptr = add;
            mydelegate ptr = new mydelegate(name);
            ptr("Atharva Karyakarte");
            delFact fact = Fact;
            Console.WriteLine(fact(5));
            delEven even = Even;
            Console.WriteLine(Even(24));

            M1((a, b) => Console.WriteLine(a+b));
            
        }
    }
}
