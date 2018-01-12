using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknotSQLForms.Enitites
{
    class Country : EntityBase
    {
        [DisplayName("Yerkir")]
        public string Name { get; set; }
    }
}
