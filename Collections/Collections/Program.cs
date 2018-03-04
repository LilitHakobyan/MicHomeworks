using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection users=new UserCollection();
            //foreach (var user in users)
            //{
            //    Console.WriteLine(user.ToString());
            //}

            IEnumerable enumerable=users as IEnumerable;

            IEnumerator enumerator = users.GetEnumerator();
            while (enumerator.MoveNext())
            {
                User user = enumerator.Current as User;
                Console.WriteLine(user.ToString());
            }
            Console.WriteLine("-----------------------------------------------------");
            foreach (var u in users)
            {
                Console.WriteLine(u.ToString());
            }
        }
    }
}
