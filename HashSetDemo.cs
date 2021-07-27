using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    class Emp
    {
        string ename;
        int salary;

        public Emp(string ename, int salary)
        {
            this.Ename = ename;
            this.Salary = salary;
        }

        public string Ename { get => ename; set => ename = value; }
        public int Salary { get => salary; set => salary = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
      

    }
    class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Atharva");
            hs.Add("Anirudha");
            hs.Add("Karyakarte");
            hs.Add("Atharva");

            foreach(var i in hs)
                Console.WriteLine(i);

            SortedSet<string> ss = new SortedSet<string>();
            ss.Add("Atharva");
            ss.Add("yugendra");
            ss.Add("Gautam");

            foreach(var x in ss)
                Console.WriteLine(x);
        }
    }
}
