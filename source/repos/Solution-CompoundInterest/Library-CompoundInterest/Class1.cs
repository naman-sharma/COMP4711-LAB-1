using System;

namespace CompoundInterestLib
{
    public class MathStuff
    {
        double p, r, n, t;

        public MathStuff(double p, double r, double n, double t)
        {
            this.p = p;
            this.r = r;
            this.n = n;
            this.t = t;
        }

        public double Calculate()
        {
            double a = p * Math.Pow((1 + r / n), (n * t));
            return a;
        }


    }
}
