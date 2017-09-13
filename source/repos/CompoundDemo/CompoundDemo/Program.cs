using System;
using CompoundInterestLib;

namespace Compound
{
    class Program
    {
        public static void Main(String[] args)
        {
            Double p, r, n, t;
            Console.WriteLine("Enter p:");
            double.TryParse(Console.ReadLine(), out p);

            Console.WriteLine("Enter r:");
            double.TryParse(Console.ReadLine(), out r);

            Console.WriteLine("Enter n:");
            double.TryParse(Console.ReadLine(), out n);

            Console.WriteLine("Enter t:");
            double.TryParse(Console.ReadLine(), out t);

            MathStuff calc = new MathStuff(p, r, n, t);
            Console.WriteLine(calc.Calculate());



        }
    }
}
