using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Saloon_Car
{
    class Connection
    {
        public const string ConnectionString= @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarShopDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
