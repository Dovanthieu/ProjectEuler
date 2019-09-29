using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler_20
{
    class Program
    {
        static int Sum(int n)
        {
            int sum= 0;
            BigInteger Factorial = 1;
            for (int i = 2; i <= 100; i++)
            {
                Factorial *= i;
            }
            while (Factorial > 0)
            {
                sum += (int)(Factorial % 10);
                Factorial /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = 100;
            Console.WriteLine("Result ProjectEuler_20 is {0}", Sum(n));
            Console.ReadKey();
        }
    }
}
