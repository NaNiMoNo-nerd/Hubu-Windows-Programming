﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string target = Console.ReadLine();
            GetNumOfTarget(words, target);
            Console.ReadKey();
        }
        private static void GetNumOfTarget(string words, string target)
        {
            int index = words.IndexOf(target);
            int count = 0;
            while (index != -1)
            {
                count++;
                Console.WriteLine(index);
                index = words.IndexOf(target, index + 1);
            }
            Console.WriteLine($"num of “{target}”:{count}");
        }
    }
}
