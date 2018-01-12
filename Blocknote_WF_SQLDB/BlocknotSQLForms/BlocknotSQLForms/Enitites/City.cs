using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknotSQLForms.Enitites
{
    class City : EntityBase
    {
        public string Name { get; set; }
        public int CountryID { get; set; }
    }
}