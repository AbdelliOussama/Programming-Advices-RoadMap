using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Generic_Heap_ith_Custom_Object
{
    public class Person : IComparable<Person>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Person(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        int IComparable<Person>.CompareTo(Person other)
        {
            if(other == null) return 1;
            return this.ID.CompareTo( other.ID);
        }
        public override string ToString()
        {
            return $"Name : {Name}";
        }
    }

    public class MinHeap<T>
    {
        public List<T> _Heap;
        public MinHeap()
        {
            _Heap = new List<T>();
        }

        public void Insert(T item)
        {
            _Heap.Add(item);

            HeapifyUp(_Heap.Count-1);

        }
        private void HeapifyUp(int index)
        {
            while (index>0)
            {
                int ParentIndex = (index-1)/2;
                if (Comparer<T>.Default.Compare(_Heap[index], _Heap[ParentIndex]) >=0 )
                    break;

                (_Heap[index],_Heap[ParentIndex]) = (_Heap[ParentIndex], _Heap[index]);

                index = ParentIndex;
            }           
        }

        public T Peek()
        {
           

            return _Heap[0];
        }

        public T ExtractMin()
        {
            if (_Heap.Count == 0)
                throw new InvalidOperationException(" Heap Is Empty");

            T MinValue = _Heap[0];

            _Heap[0] = _Heap[_Heap.Count-1];

            _Heap.Remove(_Heap[_Heap.Count-1]);

            _HeapifyDown(0);
            return MinValue;


        }
        private void _HeapifyDown(int index)
        {
            while(index<_Heap.Count)
            {
                int LeftIndex = index * 2 + 1;
                int RightIndex = index * 2 + 2;
                int SmallestIndex = index;

                if(LeftIndex<_Heap.Count  && (Comparer<T>.Default.Compare(_Heap[LeftIndex], _Heap[SmallestIndex])<0))
                {
                    SmallestIndex = LeftIndex;
                }

                if (RightIndex < _Heap.Count && (Comparer<T>.Default.Compare(_Heap[RightIndex], _Heap[SmallestIndex]) < 0))
                {
                    SmallestIndex = RightIndex;
                }
                if(SmallestIndex ==index)
                    break;

                (_Heap[index], _Heap[SmallestIndex]) = (_Heap[SmallestIndex], _Heap[index]);

                index=SmallestIndex;
            }
        }

        public void DispalyHeap()
        {
            Console.WriteLine(" Heap Elements");
            foreach(T element in _Heap)
            {
                Console.Write(element.ToString()+"         ");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MinHeap<Person> Minheap = new MinHeap<Person>();

            Minheap.Insert(new Person(2, "Rami"));
            Minheap.Insert(new Person(3, "Salim"));
            Minheap.Insert(new Person(1, "Oussama"));

            Minheap.DispalyHeap();

            Console.ReadKey();
        }
    }
}

   
