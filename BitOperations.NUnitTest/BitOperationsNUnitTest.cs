using System;
using BitOperations_Task1_;
using NUnit.Framework;

namespace BitOperations.NUnitTest
{
    [TestFixture]
    public class BitOperationsNUnitTest
    {
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 0)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
        [TestCase(int.MaxValue, int.MaxValue, 3, 5, ExpectedResult = int.MaxValue)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        [TestCase(15, 15, 1, 3, ExpectedResult = 15)]
        [TestCase(15, 15, 1, 4, ExpectedResult = 15)]
        [TestCase(15, -15, 0, 4, ExpectedResult = 17)]
        [TestCase(15, -15, 1, 4, ExpectedResult = 17)]
        [TestCase(-8, -15, 1, 4, ExpectedResult = -16)]
        public int  Insertion_GoodRanges_PositiveTest(int first, int second, int startPosition, int finishPosition)
        {
            return BitOperations1.Insertion(first, second, startPosition, finishPosition);
        }
        [TestCase(8, 15, -1, 5)]
        [TestCase(8, 15, 5, -1)]
        [TestCase(8, 15, 31, 5)]
        [TestCase(8, 15, 5, 31)]
        public void Insertion_BadRanges_ThrowsArgumentOutOfRangeException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => BitOperations1.Insertion(first, second, startPosition, finishPosition));
        }

        [TestCase(8, 15, 19, 14)]
        [TestCase(6, 6, 2, 1)]
        public void Insertion_EndbiggerStart_ThrowsArgumentException(int first, int second, int startPosition,
            int finishPosition)
        {
            Assert.Throws<ArgumentException>(()=> BitOperations1.Insertion(first, second, startPosition, finishPosition));
        }
    }
}
