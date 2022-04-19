using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("select number:\n 1.Flipcoin\n 2.Even or Odd\n 3.Swap Two Numbers\n 4.Vowel or Consonant\n 5.Largest Among 3 Numbers\n" +
                    " 6.Quotient And Remainder\n 7.LeapYear\n 8.Power of 2\n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin.FindFlipCoinCount();
                        break;
                    case 2:
                        EvenOrOdd.FindEvenOrOdd();
                        break;
                    case 3:
                        SwapTwoNumbers.FindSwapTwoNumbers();
                        break;
                    case 4:
                        VowelOrConsonant.FindVowelOrConsonant();
                        break;
                    case 5:
                        LargestAmong3Numbers.FindLargestNumber();
                        break;
                    case 6:
                        QuotientAndRemainder.FindQuotientAndRemainder();
                        break;
                    case 7:
                        LeapYear.FindLeapYear();
                        break;
                    case 8:
                        PowerOf2.Power2(8);
                        break;


                }

            }


        }
    }
}
