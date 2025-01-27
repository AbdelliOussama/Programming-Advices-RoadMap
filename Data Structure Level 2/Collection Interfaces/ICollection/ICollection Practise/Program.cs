using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollection_Practise
{
    public class OussamaCollection<T> : ICollection<T>
    {
        LinkedList<T> list = new LinkedList<T>();

        public int Count => list.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            list.AddLast(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
           return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OussamaCollection<string> strings = new OussamaCollection<string>();
            strings.Add("a");
            strings.Add("b");
            strings.Add("c");
            strings.Add("d");
            strings.Add("e");
            strings.Add("f");

            Console.WriteLine("My Own Collection "+string.Join(":",strings));

            Console.ReadKey();  
        }
    }
}
