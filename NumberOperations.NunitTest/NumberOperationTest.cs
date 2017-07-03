using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberOperations_task2_4_;
using NUnit.Framework;
using NumberOperations = NumberOperations_task2_4_.NumberOperations;

namespace NumberOperations.NunitTest
{
    [TestFixture]
    public class NumberOperationTest
    {
        [TestCase(new int[] {1, 2, 3, 4, 3, 2, 1}, ExpectedResult = 3)]
        [TestCase(new int[] {1, 100, 50, -51, 1, 1}, ExpectedResult = 1)]
        [TestCase(new int[] {10, 20, 4, 30}, ExpectedResult = 2)]
        int GetIndexFor2SpareParts_suchindexexists_positiveresult(int[] a)
        {
            return NumberOperations1.GetIndexFor2SpareParts(a);
        }
    }
}
