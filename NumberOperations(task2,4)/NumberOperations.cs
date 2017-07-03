using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperationsTask24
{
    public class NumberOperations
    {
        #region task2
        /// <summary>
        /// return index of element that devides array into 2 equal sum parts
        /// </summary>
        /// <param name="a">array</param>
        /// <returns> index of element that devides array into 2 equal sum parts,-1 if not exists</returns>
        /// <exception cref="ArgumentNullException">null reference array</exception>
        /// <exception cref="ArgumentException">empty array</exception>
        public static int GetIndexFor2SpareParts(int[] a)  //task2
        {
            if(a==null) throw new ArgumentNullException();
            if(a.Length == 0) throw new ArgumentException();
            int i, leftSum = a[0], rightSum = 0;
            for (int j = 1; j < a.Length; j++)
            {
                rightSum += a[j];
            }
            for (i = 1; i < a.Length; i++)
            {
                rightSum -= a[i];
                if (leftSum == rightSum) break;
                leftSum += a[i];
            }
            if (i != a.Length) return i;
            else return -1;
        }
        #endregion
        #region task4
        /// <summary>
        /// return the closest to argument number created from the same digits
        /// </summary>
        /// <param name="number">nutural number</param>
        /// <returns>closest to argument number created from the same digits,-1 if not exists</returns>
        /// <exception cref="ArgumentOutOfRangeException">number not natural</exception>
        public static int GetClosestSameDigitNumber(int number)  //task4
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
        /// /// <exception cref="ArgumentOutOfRangeException">number not natural</exception>
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
        #endregion
    }
}
