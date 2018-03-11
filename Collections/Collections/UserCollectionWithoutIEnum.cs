﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class UserCollectionWithoutIEnum
    {
        private User[] userElements;

        public UserCollectionWithoutIEnum()
        {
            userElements = new User[3];
            userElements[0] = new User("LA", 58);
            userElements[1] = new User("BR", 79);
            userElements[2] = new User("Po", 25);

        }

        private int position = -1;

        public object Current => userElements[position];

        public IEnumerator GetEnumerator() => this as IEnumerator;

        public bool MoveNext()
        {
            if (position < userElements.Length - 1)
            {
                position++;
                return true;
            }
                position = -1;
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
