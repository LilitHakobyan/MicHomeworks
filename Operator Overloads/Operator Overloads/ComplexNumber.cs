using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloads
{
    class ComplexNumber
    {
       public double Real { get; set; }
       public double Im { get;  set; }

        public ComplexNumber(double real, double im)
        {
            this.Im = im;
            this.Real = real;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real+c2.Real,c1.Im+c2.Im);
        }
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Im - c2.Im);
        }
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real * c2.Real-c1.Im*c2.Im, c1.Im * c2.Real+c1.Real*c2.Im);
        }
        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real / c2.Real, c1.Im / c2.Im);// haves chunem
        }

        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            if (Object.Equals(c1, null) && Object.Equals(c2, null))
                return true;
            if (Object.Equals(c1, null) || Object.Equals(c2, null))
                return false;
            return c1.Real == c2.Real && c1.Im == c2.Im;


        }
        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            return this==(ComplexNumber)obj;
        }

        public override int GetHashCode()
        {
            return (this.Real.GetHashCode()^this.Im.GetHashCode());
        }
    }
}
