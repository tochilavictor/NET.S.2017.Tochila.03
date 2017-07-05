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
        public static int Insertion(int number1, int number2, int i, int j)
        {
            if(i<0||i>30) throw new ArgumentOutOfRangeException($"{nameof(i)} is out of the range");
            if (j < 0 || j > 30) throw new ArgumentOutOfRangeException($"{nameof(j)} is out of the range");
            if (i>j) throw new ArgumentException();

            const int maxval = int.MaxValue;
            const byte maxbit = 31;

            int lenght = j - i + 1;
            int secondNumberMask = maxval >> maxbit - lenght;
            secondNumberMask = secondNumberMask << i;

            int num2Bits = number2 & secondNumberMask;

            int firstNumberMask = ~secondNumberMask;
            int num1Bits = number1 & firstNumberMask;

            int result = num1Bits | num2Bits;
            return result;
        }
    }
}
