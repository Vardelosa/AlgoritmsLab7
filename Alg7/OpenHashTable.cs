using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg7
{ 
    public class OpenHashTable<T>
    {
        public List<Element<T>>[] values;
        public int size = 0;
        public OpenHashTable()
        {
            values = new List<Element<T>>[20];
            for (int i = 0; i < 20; i++)
            {
                values[i] = new List<Element<T>>();
            }
        }
        public OpenHashTable(int size1)
        {
            values = new List<Element<T>>[size1];
            size = size1;
            for (int i = 0; i < size1; i++)
            {

                values[i] = new List<Element<T>>();
            }
        }

        public void Add(string key, T value)
        {
            int index = hash(key) % values.Length;
            values[index].Add(new Element<T>(key, value));
            size++;
        }
        public void Delete(string key)
        {
            int index = hash(key) % values.Length;
            foreach(var item in values[index])
            {
               if(item.key.Equals(key)) 
               {
                    values[index].Remove(item);
                    break;
               }
            }
        }
        public List<Element<T>> Search(string key)
        {
            int index = hash(key) % values.Length;
            Console.WriteLine("Matches found: ");
            int i = 1;
            foreach (var item in values[index])
            {               
                Console.WriteLine($"{i}){item.ToString()}");
                i++;
            }
            if (values[index].Count() >0)
            return values[index];
            Console.WriteLine("No matches found.\n");
            return default;
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

