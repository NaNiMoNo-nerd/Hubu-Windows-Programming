using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] target = new double[10];
            for (int i = 0; i < target.Length; i++)
            {
                target[i] = random.Next(100);
                Console.Write($"{target[i]} ");
            }
            Console.WriteLine($"\nMax num：{GetMax(target)}");
            Console.ReadKey();
        }
        private static double GetMax(params double[] num)
        {
            double result = 0;
            foreach (double i in num)
            {
                if (i > result)
                    result = i;
            }
            return result;
        }
    }
}
