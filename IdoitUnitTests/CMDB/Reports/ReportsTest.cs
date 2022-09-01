using IdoitSharp.CMDB.Reports;
using IdoitSharp.Idoit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IdoitUnitTests.CMDB
{
    [TestClass]
    public class ReportsTest : IdoitTestBase
    {
        public ReportsTest() : base()
        {
        }

        //Read
        [TestMethod]
        public void ReadTest()
        {
            var idoit = new IdoitInstance(idoitClient);
            //only test with pro version
            if (idoit.Version().type == "OPEN")
                return;
            //Arrange
            var request = new IdoitReportsInstance(idoitClient);
            var result = request.Read();

            Assert.IsFalse(result.Length == 0);

            foreach (var v in result)
            {
                Console.WriteLine(v.Title);
            }
        }
    }
}