﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapTwoNumbers
    {
        public static void FindSwapTwoNumbers()
        {
            int num1;
            int num2;
            int temp;

            Console.WriteLine("Type value of number 1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type value of number 2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\nAfter swapping values");
            Console.WriteLine("value of number 1: " + num1);
            Console.WriteLine("value of number 2: " + num2);
            Console.ReadLine();
        }
    }
}
