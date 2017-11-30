using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockNoteWinForm
{
    class Blocknot:IEnumerable<Record>
    {
        private List<Record> records;
        public event BlocknotChangeEventHandler BlocknotChanged; 
        public Blocknot()
        {
                records=new List<Record>();
        }

        public IEnumerator<Record> GetEnumerator()
        {
            return records.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(Record rec)
        {
            records.Add(rec);
            BlocknotChanged?.Invoke(this,new BlocknotChangedEventArgs()
            {
                CheType = BlocknotChangeType.Add,
                Record = rec
            });
        }
    }
}
