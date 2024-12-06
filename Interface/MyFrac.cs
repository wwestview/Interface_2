using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Interface
{
    public class MyFrac : IMyNumber<MyFrac>, IComparable<MyFrac>
    {
        BigInteger nom, denom;
        public MyFrac(MyFrac f)
        {
            this.nom = f.nom;
            this.denom = f.denom;
        }
        public MyFrac(BigInteger nom, BigInteger denom)
        {
            bool sign = (nom * denom) >= 0;
            nom = BigInteger.Abs(nom);
            denom = BigInteger.Abs(denom);
            BigInteger gcd = BigInteger.GreatestCommonDivisor(nom, denom);
            this.nom = nom / gcd;
            this.denom = denom / gcd;
            if (!sign) this.nom *= -1;
        }
        public MyFrac(int nom, int denom) : this((BigInteger)nom, (BigInteger)denom)
        {

        }
        public MyFrac Add(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom + this.denom * that.nom, this.denom * that.denom);
        }
        public MyFrac Subtract(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom - denom * that.nom, this.denom * that.denom);
        }
        public MyFrac Divide(MyFrac that)
        {
            if (that.nom == 0) throw new DivideByZeroException();
            return new MyFrac(this.nom * that.denom, this.denom * that.nom);
        }
        public MyFrac Multiply(MyFrac that)
        {
            return new MyFrac(this.nom * that.nom, this.denom * that.denom);
        }
        public override string ToString()
        {
         return $"{this.nom.ToString()}/{this.denom.ToString()}";
        }
        /*
        static public MyFrac operator +(MyFrac f1, MyFrac f2) { return f1.Add(f2); }
        static public MyFrac operator -(MyFrac f1, MyFrac f2) { return f1.Subtract(f2); }
        static public MyFrac operator *(MyFrac f1, MyFrac f2) { return f1.Multiply(f2); }
        static public MyFrac operator /(MyFrac f1, MyFrac f2) { return f1.Divide(f2); }
        */
        public int CompareTo(MyFrac other)
        {
           BigInteger leftFrac = this.nom*other.denom;
           BigInteger rightFrac = other.nom*this.denom;
            return leftFrac.CompareTo(rightFrac);
        }
    }
}
   
