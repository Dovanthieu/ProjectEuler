using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler_3
{
    class Program
    {
        public static long FloorSqrt(long x)
        {
            if (x == 0 || x == 1)
                return x;

            long start = 1; long end = x, ans = 0;
            while (start <= end)
            {
                long mid = (start + end) / 2;

                if (mid * mid == x)
                    return mid;

                if (mid * mid < x)
                {
                    start = mid + 1;
                    ans = mid;
                }

                else
                    end = mid - 1;
            }
            return ans;
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
