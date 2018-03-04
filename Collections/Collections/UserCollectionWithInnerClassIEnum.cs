using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class UserCollectionWithInnerClassIEnum:IEnumerable<User>
    {
        private User[] userElements = null;

        public UserCollectionWithInnerClassIEnum()
        {
            userElements = new User[3];
            userElements[0] = new User("LA", 58);
            userElements[1] = new User("BR", 79);
            userElements[2] = new User("Po", 25);

        }

        public IEnumerator<User> GetEnumerator()
        {
              return  new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }

        class Enumerator : IEnumerator<User>
        {
            private UserCollectionWithInnerClassIEnum MyCollection;

            public Enumerator(UserCollectionWithInnerClassIEnum collection)
            {
                this.MyCollection = collection;
            }
            int currentindex = -1;
            public User Current => MyCollection.userElements[currentindex];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                Console.WriteLine("dispose");
            }

            public bool MoveNext()
            {
                if (currentindex++ < MyCollection.userElements.Length - 1)
                    return true;
                currentindex = -1;
                return false;
            }

            public void Reset()
            {
                currentindex = -1;
            }
        }
    }
}
