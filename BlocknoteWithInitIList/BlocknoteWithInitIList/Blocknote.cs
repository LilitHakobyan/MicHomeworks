using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknoteWithInitIList
{
   
    class Blocknote:IList<Record>
    {
        private Record[] recordArray;
        #region MyRegion

        public int Count => recordArray.Length;
       

        public bool IsReadOnly => false;

        public int IndexOf(Record item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(recordArray[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, Record item)
        {
            Record[] newRecord=new Record[Count + 1];
            for (int i = 0; i < index; i++)
            {
                newRecord[i] = recordArray[i];
            }
            newRecord[index] = item;
            for (int i = index; i < Count; i++)
            {
                newRecord[i+1] = recordArray[i];
            }
            recordArray = newRecord;
        }

        

        public void Clear()
        {
            recordArray = new Record[0];
        }

        public bool Contains(Record item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(recordArray[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Record[] array, int arrayIndex)
        {
            int j = 0;
            for (int i = arrayIndex; i < Count; i++)
            {
                array[j++] = recordArray[i];
            }
        }

        bool ICollection<Record>.Remove(Record item)
        {
            if (Contains(item))
            {
                Remove(item);
                return true;
            }
            return false; 
                
        }

        public IEnumerator<Record> GetEnumerator()
        {
            foreach (Record item in recordArray)
            {
                yield return item;
            }
        }

      
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        #endregion
        public Blocknote()
        {
            recordArray=new Record[0];
        }

        public Record this[int index]
        {
            get =>recordArray[index]; 
            set =>recordArray[index] = value;
        }

        public Record this[string name]
        {
                get
                {
                    for (int i = 0; i < Count; i++)
                    {
                        if (recordArray[i].Name == name)
                            return recordArray[i];
                    }
                    throw new ArgumentException();
                }
        }
        public void Add(Record record)
        {
            Record[] tempRecord = new Record[Count + 1];
            recordArray.CopyTo(tempRecord, 0);
            tempRecord[Count] = record;
            recordArray = tempRecord;
        }


        public void Remove(Record record)
        {
            int j = 0;
            for (int i = 0; i < Count; i++)
            {

                if (record.Equals(recordArray[i]))
                {
                    j++;
                }
            }
            Record[] newRecord = new Record[Count - j];

            if (Contains(record))
            {
                int k = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (!record.Equals(recordArray[i]))
                    {
                        newRecord[k] = recordArray[i];
                        k++;
                    }
                }
                recordArray = newRecord;
            }
            else
            {
                throw new ArgumentException("Item not found");
            }
        }

        public void RemoveAt(int index)
        {
            Record[] newRecords = new Record[Count - 1];
            if (index >= 0 && index < recordArray.Length)
            {
                for (int i = 0; i < index; i++)
                {
                    newRecords[i] = recordArray[i];
                }
                
                for (int i = index + 1; i < Count; i++)
                {
                    newRecords[i - 1] = recordArray[i];
                }
            }

            else
            {
                throw new ArgumentOutOfRangeException("Argument out of Range");
            }
        }

        public void ShowOnConsole()
        {
            if (recordArray.Length != 0)
            {
                foreach (var rec in recordArray)
                {
                    Console.WriteLine(rec.ToString());
                }
            }
            else
            {
                throw new ArgumentException("Bloknot doesn't have any records");
            }
        }


    }
}
