using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class MyComplex : IMyNumber<MyComplex>
    {
        double re;
        double im;
        public MyComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public MyComplex(MyComplex complex)
        {
            this.re=complex.re;
            this.im=complex.im;
        }
        public MyComplex Add(MyComplex that)
        {
            return new MyComplex(this.re + that.re, this.im + that.im); // a -> this.re; c -> that.re;
                                                                        // b -> this.im; d -> that.im;
        }
        public MyComplex Subtract(MyComplex that)
        {
            return new MyComplex(this.re - that.re, this.im - that.im);
        }
        public MyComplex Multiply(MyComplex that)
        {
            return new MyComplex(this.re * that.re - this.im * that.im, this.re * that.im + this.im * that.re);
        }
        public MyComplex Divide(MyComplex that)
        {
            double a = this.re; double b = this.im;double c = that.re; double d = that.im;
            double denominator = c * c + d * d;
            if( denominator == 0) throw new DivideByZeroException();
            double firstPart = a*c+b*d/denominator;
            double secondPart = b*c-a*d/denominator;
            return new MyComplex(firstPart, secondPart);
        }
        public override string ToString()
        {
            return $"{re} {(im >= 0 ? "+" : "-")} {Math.Abs(im)}i";
        }
    }
}
    

