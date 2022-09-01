using IdoitSharp.CMDB.Logbook;
using IdoitSharp.CMDB.Object;
using IdoitSharp.Contants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IdoitUnitTests.CMDB
{
    [TestClass]
    public class LogbookTest : IdoitTestBase
    {
        public LogbookTest() : base()
        {
        }

        [TestMethod]
        public void CreateReadTest()
        {
            int objectId;
            var objectRequest = new IdoitObjectInstance(idoitClient);

            //Act:Create the Object
            objectRequest.CmdbStatus = IdoitCmdbStatus.INOPERATION;
            objectRequest.Type = IdoitObjectTypes.CLIENT;
            objectRequest.Value = "My Client";
            objectId = objectRequest.Create();

            var request = new IdoitLogbookInstance(idoitClient);
            request.Message = "Just a test";
            request.ObjectId = objectId;
            var logId = request.Create();

            var result = request.Read(objectId, DateTime.Today);
            Assert.IsTrue(result.Length > 0, "No objects found");
            objectRequest.ObjectId = objectId;
            objectRequest.Purge();
        }
    }
}