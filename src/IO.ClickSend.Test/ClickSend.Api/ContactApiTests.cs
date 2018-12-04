/* 
 * ClickSend v3 REST API
 *
 *  This is the official [ClickSend](https://clicksend.com) SDK.  *You'll need to create a free account to use the API. You can register [here](https://www.clicksend.com/signup).*  You can use our API documentation along with the SDK. Our API docs can be found [here](https://developers.clicksend.com). 
 *
 * OpenAPI spec version: 3.1.0
 * Contact: support@clicksend.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.ClickSend.Model;

namespace IO.ClickSend.Test
{
    /// <summary>
    ///  Class for testing ContactApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContactApiTests
    {
        private ContactApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContactApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContactApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContactApi
            //Assert.IsInstanceOfType(typeof(ContactApi), instance, "instance is a ContactApi");
        }

        
        /// <summary>
        /// Test ListsContactsByListIdAndContactIdDelete
        /// </summary>
        [Test]
        public void ListsContactsByListIdAndContactIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? listId = null;
            //int? contactId = null;
            //var response = instance.ListsContactsByListIdAndContactIdDelete(listId, contactId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ListsContactsByListIdAndContactIdGet
        /// </summary>
        [Test]
        public void ListsContactsByListIdAndContactIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? listId = null;
            //int? contactId = null;
            //var response = instance.ListsContactsByListIdAndContactIdGet(listId, contactId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ListsContactsByListIdAndContactIdPut
        /// </summary>
        [Test]
        public void ListsContactsByListIdAndContactIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? listId = null;
            //int? contactId = null;
            //Contact contact = null;
            //var response = instance.ListsContactsByListIdAndContactIdPut(listId, contactId, contact);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ListsContactsByListIdGet
        /// </summary>
        [Test]
        public void ListsContactsByListIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? listId = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.ListsContactsByListIdGet(listId, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ListsContactsByListIdPost
        /// </summary>
        [Test]
        public void ListsContactsByListIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Contact contact = null;
            //int? listId = null;
            //var response = instance.ListsContactsByListIdPost(contact, listId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ListsRemoveOptedOutContactsByListIdAndOptOutListIdPut
        /// </summary>
        [Test]
        public void ListsRemoveOptedOutContactsByListIdAndOptOutListIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? listId = null;
            //int? optOutListId = null;
            //var response = instance.ListsRemoveOptedOutContactsByListIdAndOptOutListIdPut(listId, optOutListId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ListsTransferContactPut
        /// </summary>
        [Test]
        public void ListsTransferContactPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fromListId = null;
            //int? contactId = null;
            //int? toListId = null;
            //var response = instance.ListsTransferContactPut(fromListId, contactId, toListId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
