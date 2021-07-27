using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections.Delegates
{
    delegate void mydelegate3(int a, int b);
    class Class2
    {
        static void sum(int a , int b)
        {
            Console.WriteLine("Addition is "+(a+b));
        }
        static void sub(int a, int b)
        {
            Console.WriteLine("Subtraction is " + (a - b));
        }
        static void mul(int a, int b)
        {
            Console.WriteLine("Multiplication is " + (a * b));
        }
        static void div(int a, int b)
        {
            Console.WriteLine("Division is " + (a / b));
        }
        static void Main(string[] args)
        {
            mydelegate3 ptr = sum;
            ptr += mul;
            ptr(5, 4);
        }
    }
}
