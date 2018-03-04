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
            UserCallectionWithYieldReturn yieldUsers=new UserCallectionWithYieldReturn();
            foreach (var yieldUser in yieldUsers)
            {
                Console.WriteLine(yieldUser.ToString());
            }
            Console.WriteLine("------------------------------------------------");
            UserCollectionWithInnerClassIEnum mycallection=new UserCollectionWithInnerClassIEnum();
            foreach (var call in mycallection)
            {
                Console.WriteLine(call.ToString());
            }
            Console.WriteLine("------------------------------------");
            UserCollectionNew userNew=new UserCollectionNew();

            foreach (var user in userNew)
            {
                Console.WriteLine(user.ToString());
            }
            Console.WriteLine("-------------------------------");
            UserCollection users = new UserCollection();
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
