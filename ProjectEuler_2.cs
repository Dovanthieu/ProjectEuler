using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler_2
{
    class Program
    {
        static int SumFib(int number)
        {
            if (number < 2)
                return 0;
            int Fib1 = 0;
            int Fib2 = 2;
            int sum = Fib1 + Fib2;
            while (Fib2 <= number)
            {
                int Fib3 = 4 * Fib2 + Fib1;
                if (Fib3 > number)
                    break;
                Fib1 = Fib2;
                Fib2 = Fib3;
                sum += Fib2;
            }
            return (int)sum;
        }
        static void Main(string[] args)
        {
            int number = 4000000;
            Console.WriteLine("Result ProjectEuler_2 is {0}",SumFib(number));
            Console.ReadKey();

        }
    }
}
