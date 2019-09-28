using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler_4
{
    class Program
    {
        static int Reverse(int number)
        {
            int reverse = 0;
            while(number>0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            return reverse;
        }
        static int Max(int a, int b)
        // Max của số palindromic  trong đoạn từ a -> b
        {
            int max = 0;
            for (int i =a;i<=b;i++)
            {
                for (int j = a; j <= b; j++)
                {
                    int k = i * j;
                    if ((k == Reverse(k))&&(k>max))
                    {
                        max = k;
                    }                
                }
            }
            return max;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Result ProjectEuler_4 is {0}", Max(100, 1000));
            Console.ReadKey();
        }
    }
}
