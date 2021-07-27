using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    class HW1:IComparable<HW1>
    {
        int bookid;
        string bookname;

        public HW1(int bookid, string bookname)
        {
            this.Bookid = bookid;
            this.Bookname = bookname;
        }

        public int Bookid { get => bookid; set => bookid = value; }
        public string Bookname { get => bookname; set => bookname = value; }

        
        
        public int CompareTo(HW1 other)
        {
            return this.Bookid - other.Bookid;
        }
    
    }
    class Term
    {
        static void Main(string[] args)
        {
            
            HashSet<HW1> bk = new HashSet<HW1>();
            bk.Add(new HW1(1, "Think and Grow Rich"));
            bk.Add(new HW1(2, "Attitude is Everything"));
            bk.Add(new HW1(3, "Power of Subconsicous Mind"));

            foreach (var a in bk)
                Console.WriteLine(a.Bookid + " " + a.Bookname);

            SortedSet<HW1> sk = new SortedSet<HW1>();
            sk.Add(new HW1(4, "The Art of War"));
            sk.Add(new HW1(5, "The Power of Positive Thinking"));
            sk.Add(new HW1(6, "Atomic Habits"));

            foreach(var b in sk)
                Console.WriteLine(b.Bookid+" "+b.Bookname);
        }
    }
}
