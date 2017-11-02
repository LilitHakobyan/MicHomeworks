using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
   public class DynamicArray
    {
        private int[] innerArray;

        public DynamicArray()
        {
            innerArray = new int[0];
        }

        public DynamicArray(int[] arr)
        {
            innerArray = arr;
        }

        public void Add(int item)
        {
            int[] tempArr = new int[innerArray.Length + 1];
            for (int i = 0; i < innerArray.Length; i++)
            {
                tempArr[i] = innerArray[i];
            }
            tempArr[innerArray.Length] = item;
            innerArray = tempArr;

        }

        public bool Contains(int item)
        {
            for (int i = 0; i < innerArray.Length; i++)
            {
                if (innerArray[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public int Find(int item)
        {
            if (Contains(item))
            {
                for (int i = 0; i < innerArray.Length; i++)
                {
                    if (innerArray[i]==item)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public void Remove(int item)
        {
            int[] tempArr = new int[innerArray.Length - 1];
            int index = Find(item);
            if (index!=-1)
            {
                for (int i = 0; i < innerArray.Length; i++)
                {
                    if (i==index)
                    {
                        for (int j = i; j < tempArr.Length; j++)
                        {
                            tempArr[j] = innerArray[j+1];
                        }
                        break;
                    }
                    tempArr[i] = innerArray[i];
                }
                innerArray = tempArr;
            }
            else
            {
                throw new Exception("item not found");
            }
            
        }

        public void ShowOnConsole()
        {
            for (int i = 0; i < innerArray.Length; i++)
            {
                Console.Write(innerArray[i] + " ");
            }
            Console.WriteLine();
        }
        
    }
}
