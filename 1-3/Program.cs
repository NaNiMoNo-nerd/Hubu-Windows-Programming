using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double sum, sub, mul, div;
            Calculate(a, b, out sum, out sub, out mul, out div);
            Console.WriteLine($"The sum of the two numbers:{sum}");
            Console.WriteLine($"The sub of the two numbers:{sub}");
            Console.WriteLine($"The mul of the two numbers:{mul}");
            Console.WriteLine($"The div of the two numbers:{div}");
            Console.ReadKey();
        }
        private static void Calculate(double x, double y, out double sum, out double sub, out double mul, out double div)
        {
            sum = x + y;
            sub = x - y;
            mul = x * y;
            div = x / y;
        }
    }
}
