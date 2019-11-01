using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg7
{ 
    public class HashTable<T>
    {
        public List<Element<T>>[] values;
        public HashTable()
        {
            values = new List<Element<T>>[20];
            for (int i = 0; i < 20; i++)
            {
                values[i] = new List<Element<T>>();
            }
        }
        public HashTable(int size1)
        {
            values = new List<Element<T>>[size1];
            size = size1;
            for (int i = 0; i < size1; i++)
            {

                values[i] = new List<Element<T>>();
            }
        }
        public int size = 0;
        
        //public bool Count()
        //{
        //    double refer = 0;
        //    refer = (size / values.Length) * 100;
        //    if (refer > 70.0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //private void Resize(int max)
        //{
        //    T[] temp = new T[max];
        //    for (int i = 0; i < values.Length; i++)
        //        temp[i] = values[i];
        //    values = temp;
        //}
        public void Add(string key, T value)
        {
            //if (Count())
            //{
            //    Resize(10);
            //}
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
                    item.value = default;
                    item.key = default;
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
            //if (values[index].Equals(default(T)))
            //{
            //    Console.WriteLine("There is no such element.\n");
            //    return default;
            //}
            //else
            //{
            //    Console.WriteLine($"Here is your element: {values[index].ToString()}");
            //    return values[index];
            //}
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

