using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler_9
{
    class Program
    {

        static int FinMutiPythagorean(int n)
        {
            int i = 0;
            int j = n / 3;
            int a = 0;
            int b = 0;
            int c = 0;
            for (i = 0; i <= (n / 3); i++)
                for (j = n / 3; ((n / 3) <= j) && (j <= n); j++)
                    if (Math.Pow(n - i - j, 2) + Math.Pow(i, 2) == Math.Pow(j, 2))
                    {
                        a = i;
                        b = n - i - j;
                        c = j;
                    }
            return a * b * c;
        }
        static void Main(string[] args)
        {
            int n = 1000;
            Console.WriteLine("Result ProjectEuler_9 is {0}", FinMutiPythagorean(n));
            Console.ReadKey();

        }
    }
}
