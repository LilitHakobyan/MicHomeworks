using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerablTest
{
    class myClacc:IEnumerable<int>
    {
        private int[] inats;
        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in inats)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            var enumerator = GetEnumerator();
            return enumerator;
        }
    }

    class MyInteratorTest : IEnumerator<int>
    {
        private int[] arr = new[] {1, 2, 3, 4,5, 6};
        private int index = -1;
        public object Current => arr[index];

        int IEnumerator<int>.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }

        public bool MoveNext()
        {
           return ++index < arr.Length;
        }

        public void Reset()
        {
            index = -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyInteratorTest colection=new MyInteratorTest();
            foreach (var item in colection)
            {
                Console.WriteLine(item);
            }
            foreach (var item in colection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
