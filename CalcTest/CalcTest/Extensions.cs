using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest
{
    static class Extensions
    {
        public static bool CheckParametersTypes(
            this IEnumerable<ParameterInfo> parameters,
            Type t)
        {
            foreach (ParameterInfo item in parameters)
            {
                if (item.ParameterType != t)
                    return false;
            }

            return true;
        }
    }
}
