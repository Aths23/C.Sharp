using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections.Delegates
{
    delegate int mydel(int c);
    class HW2   
    {
        static int Square(int c)
        {
            return c * c;
        }
        static void Cube(int d)
        {
            Console.WriteLine(d*d*d);
        }
        static bool DivisibleBy3(int o)
        {
            return o % 3 == 0;
        }
        static void Main(string[] args)
        {
            
            mydel sqr = new mydel(Square);
            Console.WriteLine(sqr(5));
            
            Action<int> cub = Cube;
            Console.WriteLine(cub);
            
            Func<int, int, int> area = (l, b) => l * b;
            Console.WriteLine(area(6, 4));
            
            Predicate<int> db3 = DivisibleBy3;
            Console.WriteLine(db3(729));
        }
    }
}
