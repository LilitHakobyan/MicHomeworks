using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blocknote
{
    class Bloknote
    {
        private Record[] recordArray;

        public Bloknote()
        {
            recordArray=new Record[0];
        }

        public void Add(Record record)
        {
            Record [] tempRecord=new Record[recordArray.Length+1];
            recordArray.CopyTo(tempRecord,0);
            tempRecord[recordArray.Length] = record;
            recordArray = tempRecord;
        }

        public int InfexOf(Record record)
        {
            for (int i = 0; i < recordArray.Length; i++)
            {
                if (record.Equals(recordArray[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contain(Record record)
        {
            for (int i = 0; i < recordArray.Length; i++)
            {
                if (record.Equals(recordArray[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(Record record)
        {
            int j = 0;
            for (int i = 0; i < recordArray.Length; i++)
            {
               
                if (record.Equals(recordArray[i]))
                {
                   j++;
                }
            }
            Record[] newRecord = new Record[recordArray.Length - j];

            if (Contain(record))
            {
               int  k = 0;
                for (int i = 0; i < recordArray.Length; i++)
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
            Record[] newRecords=new Record[recordArray.Length-1];
            if (index>=0 && index<recordArray.Length)
            {
                recordArray.CopyTo(newRecords, index);
                for (int i = index+1; i < recordArray.Length; i++)
                {
                    newRecords[i - 1] = recordArray[i];
                }
            }
           
            else
            {
                throw new ArgumentOutOfRangeException("Argument out of Range");
            }
        }

        public Record this[int index]
        {
            get { return recordArray[index]; }
            set
            {
                if (recordArray != null)
                {
                    recordArray[index] = value;
                }
            }
        }

        public Record this[string index]
        {
            get
            {
                for (int i = 0; i < recordArray.Length; i++)
                {
                    if (recordArray[i].Name==index)
                    {
                        return recordArray[i];
                    }
                }
                throw  new ArgumentException("Name index not found");
            }
            set
            {
                for (int i = 0; i < recordArray.Length; i++)
                {
                    if (recordArray[i].Name == index)
                    {
                        recordArray[i] = value;
                    }
                }
            }
        }

        public void ShowOnConsole()
        {
            if (recordArray.Length!=0)
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
