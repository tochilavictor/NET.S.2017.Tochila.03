using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BitOperations_Task1_
{
    /// <summary>
    /// provides methods dealing with bits in numbers
    /// </summary>
    public class BitOperations1
    {
        /// <summary>
        /// insert some bits in number from another number into specified pozitions
        /// </summary>
        /// <param name="number1">number, which bits will be replaced</param>
        /// <param name="number2">number for replacing bits</param>
        /// <param name="start">start position of insert</param>
        /// <param name="end">end position of insert</param>
        /// <exception cref="ArgumentOutOfRangeException">Invalid ranges</exception>
        /// <exception cref="ArgumentException">start is bigger than end</exception>
        /// <returns>result number, getted by inserting second number bits into first</returns>
        public static int Insertion(int number1, int number2, int start, int end)
        {
            if((start<0||start>30)||(end<0||end>30)) throw new ArgumentOutOfRangeException();
            if(start>end) throw new ArgumentException();
            var num1Bits = new BitArray(new int[] {number1});
            var num2Bits = new BitArray(new int[] {number2});
            for (int i = start; i <= end; i++)
            {
                num1Bits[i] = num2Bits[i - start] | num1Bits[i]; //chages only 0 to 1, but not 1 to 0
            }
            var bytes = new byte[num1Bits.Length/8];
            num1Bits.CopyTo(bytes,0);
            int res = BitConverter.ToInt32(bytes, 0);
            return res;
        }
    }
}
