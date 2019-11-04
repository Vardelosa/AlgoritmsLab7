using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg7
{
    public class Element<T> : OpenHashTable<T>
    {
        public string key;
        public T value;
        public int index;
        public Element(string key, T value)
        {
            this.key = key;
            this.value = value;
        }
        public Element()
        {
            key = "empty";
            value = default(T);
        }
        public bool IsEmpty()
        {
            if (this.key.Equals("empty"))
            {
                return true;
            }
            else
                return false;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
