using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetADDReadeImageFromDB
{
    static class Utility
    {
       public static string connectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                                        "Initial Catalog = ImageDB; " +
                                        "Integrated Security = True";
    }
}
