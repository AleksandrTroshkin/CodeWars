using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests = new int[][]
            {
                new int[] { },
                new int[] { 0, 0 },
                new int[] { 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 4, 3, 6 },
                new int[] { 7, 6, 21 },
                new int[] { 12, 30, 21 },
                new int[] { 2, 2, 2, 0 },
                new int[] { 937640, 767456, 981242 },
                new int[] { 123232, 694022, 140249 },
                new int[] { 499942, 898102, 846073 }
            };
            var results = new int[] { 1, 1, 1, 1, 4, 1, 6, 4, 0, 6, 6 };

            for (var i = 0; i < tests.Length; i++)
            {
                for (var j = 0; j < tests[i].Length; j++)
                {
                    Console.Write(tests[i][j]);
                    Console.Write(" ");
                }
                Console.Write($" - {results[i]} - {LastDigit(tests[i])}");
                Console.WriteLine();
            }


        }

        public static int LastDigit(int[] array)
        {
            if (array.Length == 0)
                return 1;
            if (array.Length == 1)
                return array[0];

            // приводим входные данные к BigInteger
            var bigInt = new BigInteger[array.Length];
            for (var i = 0; i < array.Length; i++)
                bigInt[i] = (BigInteger)array[i];

            // считаем степени
            BigInteger pow = bigInt.Length - 1;
            for (var i = bigInt.Length - 2; i >= 0; i--)
                pow = BigInteger.ModPow(bigInt[i], pow, 100);

            var result = (int)(pow % 10);
            return result;
        }
    }
}
