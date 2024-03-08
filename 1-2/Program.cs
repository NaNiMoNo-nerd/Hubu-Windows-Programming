using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 20;
            Swap(ref n1, ref n2);
            Console.WriteLine($"n1={n1},n2={n2}");
            Console.ReadKey();
        }
        private static void Swap(ref int x, ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
        }
    }
}
