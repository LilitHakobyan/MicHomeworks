using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknoteWithInitIList
{
    class Record
    {
        public string Name { get; set; }
        public string Phone { get; set; }

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
