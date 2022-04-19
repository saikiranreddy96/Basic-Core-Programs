using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        public static void FindFlipCoinCount()
        {
            int tailcount = 0, headcount = 0;
            Random random = new Random();
            Console.WriteLine("enter number of times to flipcoin");
            int numberoftimes = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < numberoftimes; i++)
            {
                double input = random.NextDouble();
                if (input == 0.5)
                    tailcount++;
                else
                    headcount++;
            }
            Console.WriteLine("headcount:{0} tailcount:{1}", headcount, tailcount);
            double headpercentage = (headcount * 100) / numberoftimes;
            double tailpercentage = (tailcount * 100) / numberoftimes;
            Console.WriteLine("Head percentage:{0}% Tail percentage:{1}%", headpercentage, tailpercentage);
        }
    }
}
