using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg7
{
    public class Element<T> : HashTable<T>
    {
        public string key;
        public T value;
        public Element(string key, T value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
