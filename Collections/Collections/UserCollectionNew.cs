using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class UserCollectionNew:IEnumerable<User>,IEnumerator<User>
    {
        private User[] userElements = null;

        public UserCollectionNew()
        {
            userElements = new User[3];
            userElements[0] = new User("LA", 58);
            userElements[1] = new User("BR", 79);
            userElements[2] = new User("Po", 25);

        }

        private int position = -1;
        public User Current => userElements[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Console.WriteLine("dispose");
        }

        public IEnumerator<User> GetEnumerator()
        {
            return this as IEnumerator<User>;
        }

        public bool MoveNext()
        {
            if (position++ < userElements.Length - 1)
                return true;
            position = -1;
            return false;

        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
          return  GetEnumerator();
        }
    }
}
