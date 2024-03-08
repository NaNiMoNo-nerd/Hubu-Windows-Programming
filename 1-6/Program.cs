using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PascalsTriangle(10);
            Console.ReadKey();
        }
        private static uint Combination(uint x, uint y) //C(n,m)
        {
            uint ans = 1;
            for (uint i = 1; i <= y; i++, x--)
            {
                ans *= x;
            }
            for (uint i = 1; i <= y; i++)
            {
                ans /= i;
            }
            return ans;
        }
        private static void PascalsTriangle(uint n)     //杨辉三角
        {
            for (uint i = 0; i <= n; i++)
            {
                for (uint j = 0; j <= n; j++)
                {
                    Console.Write($"{Combination(i, j)}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
