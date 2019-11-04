using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg7
{
    class ClosedHashTable<T>
    {

        public ClosedHashTable()
        {
            values = new Element<T>[20];
            for (int i = 0; i < 20; i++)
            {
                values[i] = new Element<T>();
            }
        }
        public ClosedHashTable(int size)
        {
            values = new Element<T>[size];
            for (int i = 0; i < size; i++)
            {
                values[i] = new Element<T>();
            }
        }
        public int size = 0;
        private Element<T>[] values;
        public bool Count()
        {
            double refer = 0;
            refer = (size / values.Length) * 100;
            if (refer > 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Length()
        {
            return values.Length;
        }
        private void Resize(int max)
        {
            Element<T>[] temp = new Element<T>[values.Length+max];
            for (int i = 0; i < values.Length; i++)
                temp[i] = values[i];
            values = temp;
        }
        public void Add(string key, T value)
        {
            size++;
            if (Count())
            {
                Resize(10);
            }
            int index = (hash(key)) % values.Length;
            if (values[index].IsEmpty())
                values[index] = new Element<T>(key, value);
            if (values[index].key.Equals(key))
                values[index].value = value;
            else
            {
                for (int i = 0; i < values.Length; i++)
                {
                    int index1 = (hash(key) + i) % values.Length;
                    if (values[index1].IsEmpty())
                    {
                        values[index1] = new Element<T>(key, value);
                        values[index].index = index1;
                        break;
                    }

                }
            }
        }
        public void Delete(string key)
        {
            int index = hash(key) % values.Length;
            values[index].key = "deleted";
        }
        public Element<T> Search(string key)
        {
            int index = hash(key) % values.Length;
            if (values[index].key.Equals("deleted") | values[index].IsEmpty())
            {
                Console.WriteLine("There is no such element.\n");
                return default;
            }
            else
            {
                while (true) 
                { 
                    if (values[index].key.Equals(key))
                    {
                        Console.WriteLine($"Here is your element: {values[index].ToString()}");
                        return values[index];
                    }
                    index = values[index].index;
                }            
            }
        }
        public int hash(string key)
        {
            int number = 1311;
            int sum = 0;
            char[] key_ar = key.ToCharArray();
            for (int i = 0; i < key_ar.Length; i++)
            {
                sum += (number ^ i) * key_ar[i];
            }
            return sum;

        }
    }
}



