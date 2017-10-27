using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    struct StructTest
    {
        public int x;
        public int y;

        public StructTest(int x)
        {
            this.x = x;
            y = 20;
        }

        public void F(StructTest st)
        {
            this = st;
        }

    }

    class Test
    {
        public static decimal CalcTax(ClassTest T)
        {
            return T.x;
        }
    }

    class ClassTest
    {
        public int x;
        public int y;

        public ClassTest(int x)
        {
            this.x = x;
            y = 20;
        }

        public void F(ClassTest st)
        {
            //this = st; //error 
            Test.CalcTax(this);
        }
      
    }
}
