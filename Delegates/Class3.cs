using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections.Delegates
{
    class Class3
    {
        //Generic Delegates - Func(When function is returning some value except boolean), Action(return type is void), Predicate(return type is boolean)
        static void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static bool Even(int o)
        {
            return o % 2 == 0;
        }
        static void Main(string[] args)
        {
            Action<int, int> ptr1 = add;
            ptr1(8, 6);
            
            Predicate<int> ptr3 = Even;
            Console.WriteLine(ptr3(4684));

            Func<int, double> area = (r) => 3.14 * r * r;
            Console.WriteLine(area(6));
        }
    }
}
