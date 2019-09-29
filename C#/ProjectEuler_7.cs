using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler_7
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
            else if(n % 2 == 0)
                return false;
            else
            {
                for (int i = 3; i <= FloorSqrt(n) + 1; i += 2)
                    if (n % i == 0)
                        return false;
                return true;
            }
        }
        static int PrimeIndexN(int n)
        {
            int PrimeNum = 1;
            int count = 1;
            while(PrimeNum<10001)
            {
                count += 2;
                if (IsPrime(count))
                {
                    PrimeNum++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int n = 10001;
            Console.WriteLine("Result ProjectEuler_7 is {0}", PrimeIndexN(n));
            Console.ReadKey();
        }
    }
}
