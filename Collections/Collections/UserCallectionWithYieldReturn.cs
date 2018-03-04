using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class UserCallectionWithYieldReturn:IEnumerable<User>
    {
        private User[] userElements = null;

        public UserCallectionWithYieldReturn()
        {
            userElements = new User[3];
            userElements[0] = new User("LA", 58);
            userElements[1] = new User("BR", 79);
            userElements[2] = new User("Po", 25);

        }

        public IEnumerator<User> GetEnumerator()
        {
            for (int i = 0; i < userElements.Length; i++)
            {
                yield return userElements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
