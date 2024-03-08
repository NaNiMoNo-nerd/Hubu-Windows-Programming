using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //添加第三个变量
            #region 交换两数的值
            //int n1 = 10, n2 = 20;
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;
            //Console.WriteLine("n1 = {0},n2 = {1}", n1, n2);
            //Console.ReadLine();
            #endregion
            //拓展方法：不用第三个变量
            int a = 10, b = 20;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a},b = {b}");
            Console.ReadKey();
        }
    }
}
