using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest
{
    class ExpressionCalculator
    {
        public string Expression { get; }

        public ExpressionCalculator(string expression)
        {
            this.Expression = expression;
        }

        private bool CheckFormat()
        {
            int brIndex1 = this.Expression.IndexOf("(");
            int brIndex2 = this.Expression.IndexOf(")");

            if (brIndex1 > brIndex2)
                return false;

            int openBrecketCount = 0;
            int closeBrecketCount = 0;

            foreach (char item in Expression)
            {
                if (item == '(')
                    openBrecketCount++;
                if (item == ')')
                    closeBrecketCount++;
            }

            if (openBrecketCount != 1 || closeBrecketCount != 1)
                return false;

            return true;
        }

        private string GetMethodName()
        {
            int brIndex = this.Expression.IndexOf("(");
            string methodName = this.Expression.Substring(0, brIndex);

            return methodName;
        }

        private double[] GetArguments()
        {
            int openIndex = this.Expression.IndexOf("(");
            int closeIndex = this.Expression.IndexOf(")");

            string argsStr = this.Expression.Substring(openIndex + 1,
                closeIndex - openIndex - 1);

            string[] args = argsStr.Split(',');
            double[] doubleArgs = new double[args.Length];
            int index = 0;

            try
            {
                foreach (string str in args)
                {
                    double arg = Double.Parse(str);
                    doubleArgs[index++] = arg;
                }
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Invalid format argument", e);
            }

            return doubleArgs;
        }

        private MethodInfo GetMethodInfo(string methodName, double[] args)
        {
            MethodInfo mi = null;

            foreach (MethodInfo item in typeof(Math).GetMethods())
            {
                ParameterInfo[] parameters = item.GetParameters();

                if (item.Name.ToLower().Equals(methodName) &&
                    parameters.Length == args.Length &&
                    parameters.CheckParametersTypes(typeof(double)))
                {
                    mi = item;
                    break;
                }
            }

            return mi;
        }

        public double Calculate()
        {
            if (!CheckFormat())
                throw new FormatException("Invalid format");

            string methodName = GetMethodName().ToLower();
            double[] args = GetArguments();

            MethodInfo mi = GetMethodInfo(methodName, args);

            if (mi == null)
                throw new MissingMethodException($"Method {methodName} with {args.Count()} args not found");

            object[] objArgs = new object[args.Count()];
            int index = 0;

            foreach (var item in args)
            {
                objArgs[index++] = item;
            }

            double result = (double)mi.Invoke(null, objArgs);

            return result;
        }
    }
}