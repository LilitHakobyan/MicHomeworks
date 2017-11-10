using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknoteWithInitIList
{
    class Record:IList<Record>
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public Record this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Record(string name,string phon)
        {
            this.Name = name;
            this.Phone = phon;
        }

        public override bool Equals(object obj)
        {  Record rec= obj as Record;
            if (rec != null)
                return (rec.Name == this.Name && rec.Phone == this.Phone);
            return false;
        }

        public override int GetHashCode()
        {
            return 13 * Name.GetHashCode() + 13 * Phone.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {Name}_______Phon: {Phone}";
        }

       
    }
}
