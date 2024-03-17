using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciSumOf(20));
            Console.ReadLine();
        }
        private static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                // 斐波那契数列的第1项固定为1.
                return 1;
            }
            else
            {
                int[] fib = new int[n];
                fib[0] = 1;
                fib[1] = 1;
                for (int i = 0; i < fib.Length - 2; i++)
                {
                    fib[i + 2] = fib[i] + fib[i + 1];
                }

                return fib[n - 1];
            }
        }
        private static int FibonacciSumOf(int n)
        {
            int result = 0;

            // 将斐波那契前 n 项依次相加. 
            for (int i = 0; i < n; i++)
            {
                result += Fibonacci(i + 1);
            }
            return result;
        }
    }
}
