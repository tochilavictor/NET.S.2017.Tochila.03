using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitOperations_Task1_;
using NUnit.Framework;
using NumberOperationsTask24;

namespace NumberOperationsTask24.NUnitTest
{
    [TestFixture]
    public class NumberOperationsTest
    {

        [TestCase(new int[] {1,2,4,2,1}, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 100,200,400,-100,50,600 }, ExpectedResult = 4)]
        [TestCase(new int[] {10,1,5,5 }, ExpectedResult = 1)]
        public int GetIndexFor2SpareParts_IndexExists_PositiveTest(int[] array)
        {
            return NumberOperations.GetIndexFor2SpareParts(array);
        }

        [TestCase(new int[] { 1, 2, 4, 6 , 2, 1 }, ExpectedResult = -1)]
        [TestCase(new int[] { 1,3 }, ExpectedResult = -1)]
        [TestCase(new int[] { 100 }, ExpectedResult = -1)]
        [TestCase(new int[] { 3,4,4 }, ExpectedResult = -1)]
        public int GetIndexFor2SpareParts_IndexNotExists_GetMinus1(int[] array)
        {
            return NumberOperations.GetIndexFor2SpareParts(array);
        }

        [TestCase(null)]
        public void GetIndexFor2SpareParts_NullArray_ThrowsArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => NumberOperations.GetIndexFor2SpareParts(array));
        }

        [TestCase(new int[] {})]
        public void GetIndexFor2SpareParts_EmptyArray_ThrowsArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => NumberOperations.GetIndexFor2SpareParts(array));
        }
        [TestCase(513,ExpectedResult = 531)]
        [TestCase(2017,ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        public int GetClosestSameDigitNumber_NumberExists_PositiveTest(int number)
        {
            return NumberOperations.GetClosestSameDigitNumber(number);
        }

        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        [TestCase(763, ExpectedResult = -1)]
        public int GetClosestSameDigitNumber_NumberNotExists_GetMinus1(int number)
        {
            return NumberOperations.GetClosestSameDigitNumber(number);
        }
    }
}
