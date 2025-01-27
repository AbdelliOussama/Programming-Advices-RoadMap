
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Practise
{
    public class MyCustomCollection<T> : IEnumerable<T>
    {
        T[] Array = new T[10];
         
        public IEnumerator<T> GetEnumerator()
        {
            T Element ;
            for(int i = 0;i<Array.Length;i++)
            {
                Element = Array[i];
                yield return Element;
            }
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
            MyCustomCollection<int> MyCustomArray = new MyCustomCollection<int>() ;
            

            foreach(int i in MyCustomArray)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
