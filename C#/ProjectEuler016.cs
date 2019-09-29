using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler_16
{
    class Program
    {
        static Int32 SumElementNumber(Int32 n)
        {
            int result = 0;
            // Lớp BigInterger cho phép lưu trữ kết quả số lớn như 1000 bit lưu trữ
            // hoặc tới kích thước 32 số nguyên lưu trữ tham chiếu từ namespace System.Numeris
            BigInteger number = BigInteger.Pow(2, 1000);

            while (number > 0)
            {
                result += (int)(number % 10);
                number /= 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n = 1000;
            Console.WriteLine("Result ProjectEuler_16 is {0}", SumElementNumber(n));
            Console.ReadKey();
        }
    }
}
