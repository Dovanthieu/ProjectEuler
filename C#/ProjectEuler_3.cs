using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler_3
{
    class Program
    {
        public static long FloorSqrt(long n)
        {
            double i = Math.Sqrt(n);
            return (long)i;
        }
        static long SmallPrimeFactor(long n)
        {
            for (int i = 2; i <= FloorSqrt(n) + 1; i++)
                if (n % i == 0)
                {
                    return i;
                }
            return n;
        }
        static long MaxPrimeFactors(long n)
        {
            long p = SmallPrimeFactor(n);
            while (p<n)
            {
                n /= p;
                p = SmallPrimeFactor(n);
            }
            return n;
          
        }
        static void Main(string[] args)
        {
            long n = 600851475143L;
            Console.WriteLine("Result ProjectEuler_3 is {0}", MaxPrimeFactors(n));
            Console.ReadKey();
        }
    }
}
