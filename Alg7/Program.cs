﻿using System;
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
            HashTable<int> hs = new HashTable<int>(20);
            hs.Add("mama", 5);
            hs.Add("mama", 544);
            hs.Add("amma", 432);
            hs.Add("papa", 55);
            hs.Add("ababagalamaga", 7);
            //hs.Delete("mama");
            hs.Search("mama");

            Console.ReadKey();
        }
    }
}
