using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknotSQLForms.Enitites
{
    class Address : EntityBase
    {
        public string Street { get; set; }
        public string ZIP { get; set; }
        public string PhoneNumber { get; set; }

        public int CityID { get; set; }
    }
}