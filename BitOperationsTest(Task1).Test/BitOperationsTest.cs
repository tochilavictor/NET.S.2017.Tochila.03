using System;
using BitOperations_Task1_;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitOperationsTest_Task1_.Test
{
    [TestClass]
    public class BitOperationsTest
    {
        public TestContext TestContext { get; set; }

        [DataSource(
             "Microsoft.VisualStudio.TestTools.DataSource.XML",
             "|DataDirectory|\\numbers.xml",
             "TestCase",
             DataAccessMethod.Sequential)]
        [DeploymentItem("BO.Test\\numbers.xml")]
        [TestMethod]
        public void Insertion_GoodRanges_PositiveTest()
        {
            int expected = RetrieveValue("ExpectedResult");
            int actual = BitOperations1.Insertion(RetrieveValue("FirstNumber"), RetrieveValue("SecondNumber"),
                    Convert.ToInt32(TestContext.DataRow["start"]),
                        Convert.ToInt32(TestContext.DataRow["end"]));
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        [DataSource(
             "Microsoft.VisualStudio.TestTools.DataSource.XML",
             "|DataDirectory|\\numbers.xml",
             "TestCase2",
             DataAccessMethod.Sequential)]
        [ExpectedException(typeof(ArgumentException))]
        public void Insertion_InsertWhereStartBiggerThanEnd_ThrowsArgumentException()
        {
            BitOperations1.Insertion(RetrieveValue("FirstNumber"),RetrieveValue("SecondNumber"),
                Convert.ToInt32(TestContext.DataRow["start"]),
                        Convert.ToInt32(TestContext.DataRow["end"]));
        }
        [TestMethod]
        [DataSource(
             "Microsoft.VisualStudio.TestTools.DataSource.XML",
             "|DataDirectory|\\numbers.xml",
             "TestCase1",
             DataAccessMethod.Sequential)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Insertion_InvalidRanges_ThrownArgumentOutOfRangeException()
        {
            BitOperations1.Insertion(RetrieveValue("FirstNumber"), RetrieveValue("SecondNumber"),
                Convert.ToInt32(TestContext.DataRow["start"]),
                        Convert.ToInt32(TestContext.DataRow["end"]));
        }
        int RetrieveValue(string columnName)
        {
            int result;
            if (TestContext.DataRow[columnName].ToString().Equals("int.MaxValue")) result = int.MaxValue;
            else if (TestContext.DataRow[columnName].ToString().Equals("int.MinValue")) result = int.MinValue;
            else result = Convert.ToInt32(TestContext.DataRow[columnName]);
            return result;
        }
    }
}
