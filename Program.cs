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
            var result = 0;
            result = LastDigit(new int[] { });
            Console.WriteLine(result);
            result = LastDigit(new int[] { 0, 0 });
            Console.WriteLine(result);
            result = LastDigit(new int[] { 1, 2 });
            Console.WriteLine(result);
            result = LastDigit(new int[] { 3, 4, 5 });
            Console.WriteLine(result);
            result = LastDigit(new int[] { 4, 3, 6 });
            Console.WriteLine(result);
            result = LastDigit(new int[] { 7, 6, 21 });
            Console.WriteLine(result);
            result = LastDigit(new int[] { 12, 30, 21 });
            Console.WriteLine(result);
            result = LastDigit(new int[] { 2, 2, 2, 0 });
            Console.WriteLine(result);
            result = LastDigit(new int[] { 937640, 767456, 981242 });
            Console.WriteLine(result);
            result = LastDigit(new int[] { 123232, 694022, 140249 });
            Console.WriteLine(result);
            result = LastDigit(new int[] { 499942, 898102, 846073 });
            Console.WriteLine(result);
        }

        public static int LastDigit(int[] array)
        {
            if (array.Length == 0)
                return 1;
            if (array.Length == 1)
                return array[0];

            var test = Math.Pow(7, 26);

            var digits = new int[array.Length];
            for (var i = 0; i < digits.Length; i++)
                digits[i] = (array[i] % 10) == 1 ? 21 : array[i] % 10;

            double pow = digits[digits.Length - 1];
            for (var i = digits.Length - 2; i >= 0; i--)
                pow = ((Math.Pow(digits[i], pow)) % 10) + 20;

            return (int)pow % 10;
        }
    }
}
