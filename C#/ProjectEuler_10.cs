using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler_10
{
    class Program
    {
        public static int FloorSqrt(int n)
        {
            double i = Math.Sqrt(n);
            return (int)i;
        }
        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            else if (n <= 3)
                return true;
            else if (n % 2 == 0)
                return false;
            else
            {
                for (int i = 3; i <= FloorSqrt(n) + 1; i += 2)
                    if (n % i == 0)
                        return false;
                return true;
            }
        }
        static double SumPrimeN(int n)
        {
            int count = 2;
            double sum = 0;
            while (count <= n)
            {
                if (IsPrime(count))
                {
                    sum += count;                
                }
                count++;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = 2000000;
            Console.WriteLine("Result ProjectEuler_10 is {0}", SumPrimeN(n));
            Console.ReadKey();
        }
    }
}
