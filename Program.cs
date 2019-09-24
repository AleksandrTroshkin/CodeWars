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
            var result = LastDigit(new int[] { 7, 6, 21 });
                Console.WriteLine(result);

        }

        public static int LastDigit(int[] array)
        {
            if (array.Length == 0)
                return 1;
            if (array.Length == 1)
                return array[0];

            var digits = new int[array.Length];
            for (var i = 0; i < digits.Length; i++)
                digits[i] = array[i] % 100;

            double pow = digits[digits.Length - 1];
            for (var i = digits.Length - 2; i >= 0; i--)
                pow = (Math.Pow(digits[i], pow)) % 10;

            return (int)pow;
        }
    }
}
