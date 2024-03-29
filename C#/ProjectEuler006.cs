﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler_6
{
    class Program
    {
        static int SumSqrt(int n)
        {
            int sumsqrt = (n*(n + 1)*(2*n + 1)) / 6;
            return sumsqrt;
        }
        static int SqrtSum(int n)
        {
            int sqrtsum = ((n*(n + 1)) / 2)* ((n * (n + 1)) / 2);
            return sqrtsum;
        }

        static void Main(string[] args)
        {
            int n = 100;
            Console.WriteLine("Result ProjectEuler_6 is {0}", SqrtSum(n) - SumSqrt(n));
            Console.ReadKey();
        }
    }
}
