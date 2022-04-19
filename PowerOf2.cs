using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOf2
    {
        public static void Power2(int n)
        {
            int pow2 = 0;
            while (n < 0 || n > 30)
            {
                Console.Write("Enter a n(0-30): ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= n; i++)
            {
                pow2 = Convert.ToInt32(Math.Pow(2, i));
                Console.WriteLine("2^" + i + " = " + pow2);
            }
        }
    }
}
