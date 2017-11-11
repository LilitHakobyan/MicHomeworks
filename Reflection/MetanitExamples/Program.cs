using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MetanitExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myTypetype = typeof(User);
            Console.WriteLine($"1.using typeof {myTypetype}");
             User user= new User("Tom",33);
            Console.WriteLine($"2. using GetTypemethod{user.GetType()}");
            Type myType=Type.GetType("MetanitExamples.User",false,true);
            Console.WriteLine($"3. static method is class Type Type.GetType {myType}");
            foreach (MemberInfo mi in myType.GetMembers())
            {
                Console.WriteLine(mi.DeclaringType+" --"+mi.MemberType+" --"+mi.ReflectedType);
            }
            Console.WriteLine("Methods");
         
            foreach (MethodInfo method in myType.GetMethods())
            {
                string modificator = " ";
                if (method.IsStatic)
                    modificator += "static";
                if (method.IsVirtual)
                    modificator += "virtual";
                Console.Write(modificator + method.ReturnType.Name + " " + method.Name + " (");
                ParameterInfo[] parameter = method.GetParameters();
                for (int i = 0; i < parameter.Length; i++)
                {
                    Console.Write(parameter[i].ParameterType.Name + " " + parameter[i].Name);
                    if (i + 1 < parameter.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
          
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int  Payment(int hours, int perhour)
        {
            return hours * perhour;

        }
    }
}
