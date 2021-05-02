﻿using IdoitSharp.CMDB.Category;
using IdoitSharp.CMDB.Object;
using IdoitSharp.Contants;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IdoitUnitTests
{
    [TestClass]
    public class IPCategoryTest : IdoitTestBase
    {
        public IPCategoryTest() : base()
        {
        }

        ////Delete
        //[TestMethod]
        //public void DeleteTest()
        //{
        //    //Arrange
        //    int cateId, objectId;
        //    List<IPResponse[]> list = new List<IPResponse[]>();
        //    Client myClient = new Client(URL, APIKEY, LANGUAGE);
        //    myClient.Username = "admin";
        //    myClient.Password = "admin";
        //    Obj objectRequest = new Obj(myClient);
        //    IPRequset categoryRequest = new IPRequset();
        //    IP IP = new IP(myClient);

        //    //Act:Create the Object
        //    objectRequest.type = ObjectType.Client;
        //    objectRequest.title = " My Client";
        //    objectRequest.cmdbStatus = CmdbStatus.inOperation;
        //    objectId = objectRequest.Create();

        //    //Act: Create the Category
        //    categoryRequest.title = "Web GUI";
        //    categoryRequest.description = "Web GUI description";
        //    categoryRequest.type = " ES";
        //    categoryRequest.formatted_url = "https://swsan.admin.acme-it.example/";
        //    categoryRequest.primary = "3";
        //    cateId = IP.Create(objectId, categoryRequest);

        //    //Act
        //    IP.Delete(objectId, cateId);

        //    //Act:Read the Category
        //    categoryRequest.category_id = cateId;
        //    list = IP.Read(objectId);

        //    //Assert
        //    foreach (IPResponse[] row in list)
        //    {
        //        foreach (IPResponse element in row)
        //        {
        //            Assert.IsNotNull(element.title);
        //            Assert.IsNotNull(element.id);
        //        }
        //    }

        //}

        ////Quickpurge
        //[TestMethod]
        //public void QuickpurgeTest()
        //{
        //    //Arrange
        //    int cateId, objectId;
        //    Client myClient = new Client(URL, APIKEY, LANGUAGE);
        //    myClient.Username = "admin";
        //    myClient.Password = "admin";
        //    Obj objectRequest = new Obj(myClient);
        //    IPRequset categoryRequest = new IPRequset();
        //    IP IP = new IP(myClient);

        //    //Act:Create the Object
        //    objectRequest.type = ObjectType.Client;
        //    objectRequest.title = " My Client";
        //    objectRequest.cmdbStatus = CmdbStatus.inOperation;
        //    objectId = objectRequest.Create();

        //    //Act: Create the Category
        //    categoryRequest.title = "Web GUI";
        //    categoryRequest.description = "Web GUI description";
        //    categoryRequest.type = " ES";
        //    categoryRequest.formatted_url = "https://swsan.admin.acme-it.example/";
        //    categoryRequest.primary = "3";
        //    cateId = IP.Create(objectId, categoryRequest);

        //    //Act
        //    IP.Quickpurge(objectId, cateId);
        //}

        ////Update
        //[TestMethod]
        //public void UpdateTest()
        //{
        //    //Arrange
        //    int cateId, objectId;
        //    List<IPResponse[]> list = new List<IPResponse[]>();
        //    Client myClient = new Client(URL, APIKEY, LANGUAGE);
        //    myClient.Username = "admin";
        //    myClient.Password = "admin";
        //    Obj objectRequest = new Obj(myClient);
        //    IPRequset categoryRequest = new IPRequset();
        //    IP IP = new IP(myClient);

        //    //Act:Create the Object
        //    objectRequest.type = ObjectType.Client;
        //    objectRequest.title = " My Client";
        //    objectRequest.cmdbStatus = CmdbStatus.inOperation;
        //    objectId = objectRequest.Create();

        //    //Act: Create the Category
        //    categoryRequest.title = "Web GUI";
        //    categoryRequest.description = "Web GUI description";
        //    categoryRequest.type = " ES";
        //    categoryRequest.formatted_url = "https://swsan.admin.acme-it.example/";
        //    categoryRequest.primary = "3";
        //    cateId = IP.Create(objectId, categoryRequest);

        //    //Act: Update the Category
        //    categoryRequest.title = "Web GUI 2";
        //    categoryRequest.description = "Web GUI 2 description";
        //    categoryRequest.type = " SE";
        //    categoryRequest.formatted_url = "https://swsan.admin.acme-it.example/";
        //    categoryRequest.primary = "4";
        //    categoryRequest.category_id = cateId;
        //    IP.Update(objectId, categoryRequest);

        //    //Act:Read the Category
        //    categoryRequest.category_id = cateId;
        //    list = IP.Read(objectId);

        //    //Assert
        //    foreach (IPResponse[] row in list)
        //    {
        //        foreach (IPResponse element in row)
        //        {
        //            Assert.AreEqual("Web GUI 2", categoryRequest.title);
        //        }
        //    }

        //    //Act:Delete the Object
        //    objectRequest.Delete(objectId);

        //}

        //Read
        [TestMethod]
        public void CreateReadTest()
        {
            //Arrange
            int cateId, objectId;
            var objectRequest = new IdoitObjectInstance(idoitClient);
            var categoryRequest = new IPRequest();
            var IP = new IdoitMvcInstance<IPResponse>(idoitClient);

            //Act:Create the Object
            objectRequest.CmdbStatus = IdoitCmdbStatus.INOPERATION;
            objectRequest.Type = IdoitObjectTypes.CLUSTER;
            objectRequest.Value = "My Cluster 2";
            objectId = objectRequest.Create();

            //Act: Create the Category
            categoryRequest.ipv4_address = "1.1.1.2";
            categoryRequest.description = "Web GUI description";
            IP.ObjectId = objectId;
            IP.ObjectRequest = categoryRequest;
            cateId = IP.Create();

            //Act:Read the Category
            var list = IP.Read();
            Assert.IsTrue(list.Length > 0, "No objects found");
            //Assert
            foreach (IPResponse v in list)
            {
                Assert.IsNotNull(v.ipv4_address.refTitle);
            }
            //Act:Delete the Object
            objectRequest.ObjectId = objectId;
            objectRequest.Delete();
        }
    }
}