using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "  Hello   World  !   你好    世界 ！ ";
            RemoveSpace(str);
            Console.ReadKey();
        }
        private static void RemoveSpace(string str)
        {
            //通过Trim()去掉两端的空格
            string result_1 = str.Trim();

            //通过正则表达式将字符串中间的多个空格转换为单个空格
            string pattern = @"\s+";
            string Final_result = Regex.Replace(result_1, pattern, " ");

            //输出结果
            Console.WriteLine(Final_result);
        }
    }
}
