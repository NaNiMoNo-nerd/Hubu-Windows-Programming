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
            Console.WriteLine(Fibonacci(20));
            Console.ReadLine();
        }
        private static int Fibonacci(int n)
        {
            int result = 0;
            int[] fib = new int[n];
            fib[0] = 1;
            fib[1] = 1;
            for (int i = 0; i < fib.Length - 2; i++)
            {
                fib[i + 2] = fib[i] + fib[i + 1];
            }
            //for(int i = 0;)
            return fib[n - 1];
        }
    }
}
