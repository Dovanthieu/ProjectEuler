using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler_5
{
    class Program
    {
        static int gcd(int a ,int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
            
        }
        static int lcm(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
               result *= i / gcd(i, result);

            }
            return (int)result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Result ProjectEuler_5 is {0}", lcm(20));
            Console.ReadKey();
        }
    }
}
