using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class IntExtension
    {
        public static int Reverse(this int number)
        {
            int reversedNumber = 0, lastDigit;


            while (number > 0)
            {
               lastDigit = number % 10;
               number = number / 10;
               reversedNumber=reversedNumber*10 + lastDigit;
            }

            return reversedNumber;
        }
    }
}

