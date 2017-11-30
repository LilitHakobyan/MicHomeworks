using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockNoteWinForm
{
    class Record
    {
        public string Name { get; set; }
        public string  Phon { get; set; }
        public override string ToString()
        {
            return $"{this.Name} ,{this.Phon}";
        }

        public override bool Equals(object obj)
        {
            Record tempRec = obj as Record;
            if (tempRec != null)
                return (this.Name == tempRec.Name && this.Phon == tempRec.Phon);
            return false;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode()^this.Phon.GetHashCode();
        }
    }
}
