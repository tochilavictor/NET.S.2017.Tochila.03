using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperationsTask24
{
    public class NumberOperations
    {
        static public int GetIndexFor2SpareParts(int[] a)  //task2
        {
            if(a==null) throw new ArgumentNullException();
            if(a.Length == 0) throw new ArgumentException();
            int i, leftsum = a[0], rightsum = 0;
            for (int j = 1; j < a.Length; j++)
            {
                rightsum += a[j];
            }
            for (i = 1; i < a.Length; i++)
            {
                rightsum -= a[i];
                if (leftsum == rightsum) break;
                leftsum += a[i];
            }
            if (i != a.Length) return i;
            else return -1;
        }
        static public int GetClosestSameDigitNumber(int number)  //task4
        {
            if (number < 1) throw new ArgumentOutOfRangeException();
            int[] digits = NumberToDigits(number);
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] >= digits[i - 1]) continue;
                var digitsForReplacing = new int[i + 1];
                Array.Copy(digits, digitsForReplacing, i + 1);
                Array.Sort(digitsForReplacing);
                Array.Reverse(digitsForReplacing);
                digits[i] = digitsForReplacing[0];
                Array.Copy(digitsForReplacing, 1, digits, 0, digitsForReplacing.Length - 1);
                int res = 0;
                for (int j = 0; j < digits.Length; j++)
                {
                    res += (int)(digits[j] * Math.Pow(10, j));
                }
                return res;
            }
            return -1;
        }
        /// <summary>
        /// Convert natural number to array of digits in reverse order
        /// </summary>
        /// <param name="number">number for converting</param>
        /// <returns>array in reverse order(array[0]==lastdigit)</returns>
        static int[] NumberToDigits(int number)
        {
            if (number < 1) throw new ArgumentOutOfRangeException();
            int digitsCount = 0;
            int tmp = number;
            while (tmp > 0)
            {
                digitsCount++;
                tmp = tmp / 10;
            }
            tmp = number;
            var digits = new int[digitsCount];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = tmp % 10;
                tmp = tmp / 10;
            }
            return digits;
        }
    }
}
