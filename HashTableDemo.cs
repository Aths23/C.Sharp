using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Atharva", 9511781304);
            ht.Add("Baba", 9511813230);
            ht.Add("Aatya", 9890978483);
            ht.Add("Kaka", 9823148783);
            //Console.WriteLine(ht["Baba"]);
            foreach(var x in ht.Keys)
                Console.WriteLine(x);
            foreach(DictionaryEntry d in ht)
                Console.WriteLine(d.Key + "Value: "+d.Value);
        }
    }
}
