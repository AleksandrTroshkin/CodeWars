using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = LastDigit(new int[] { 0, 0, 0 });
                Console.WriteLine(result);

        }

        public static int LastDigit(int[] array)
        {
            if (array.Length == 0)
                return 1;

            var digits = new int[array.Length];
            for (var i = 0; i < digits.Length; i++)
                digits[i] = array[i] % 10;
            double pow = digits[0];
            // TODO: дожна работать с последнего числа
            for (var i = 0; i < digits.Length - 1; i++)
                pow = Math.Pow(pow, digits[i + 1]);

            return (int)(pow % 10);
        }
    }
}
