using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg7
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenHashTable<int> hs = new OpenHashTable<int>(20);
            ClosedHashTable<int> chs = new ClosedHashTable<int>();
            chs.Add("mama", 3);
            chs.Add("papa", 44);
            chs.Add("mama", 33);
            chs.Search("papa");





            //Console.WriteLine(chs.Length());
            //hs.Add("mama", 5);
            //hs.Add("mama", 544);
            //hs.Add("amma", 432);
            //hs.Add("papa", 55);
            //hs.Delete("mama");
            //hs.Add("ababagalamaga", 7);
            ////hs.Delete("mama");
            //hs.Search("mama");

            Console.ReadKey();
        }
    }
}
