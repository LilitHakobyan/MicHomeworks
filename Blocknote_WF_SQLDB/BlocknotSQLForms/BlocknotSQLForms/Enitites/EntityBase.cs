using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknotSQLForms.Enitites
{
    abstract class EntityBase
    {
        [Browsable(false)]
        public int ID { get; set; } = -1;

        //public abstract void Update(int ID);       
    }
}