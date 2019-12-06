/* 
 * ClickSend v3 API
 *
 *  This is an official SDK for [ClickSend](https://clicksend.com)  Below you will find a current list of the available methods for clicksend.  *NOTE: You will need to create a free account to use the API. You can register [here](https://dashboard.clicksend.com/#/signup/step1/)..* 
 *
 * OpenAPI spec version: 3.1
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
    ///  Class for testing TransactionalEmailApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TransactionalEmailApiTests
    {
        private TransactionalEmailApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransactionalEmailApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransactionalEmailApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TransactionalEmailApi
            //Assert.IsInstanceOfType(typeof(TransactionalEmailApi), instance, "instance is a TransactionalEmailApi");
        }

        
        /// <summary>
        /// Test EmailHistoryExportGet
        /// </summary>
        [Test]
        public void EmailHistoryExportGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filename = null;
            //int? dateFrom = null;
            //int? dateTo = null;
            //var response = instance.EmailHistoryExportGet(filename, dateFrom, dateTo);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailHistoryGet
        /// </summary>
        [Test]
        public void EmailHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? dateFrom = null;
            //int? dateTo = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.EmailHistoryGet(dateFrom, dateTo, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailPricePost
        /// </summary>
        [Test]
        public void EmailPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Email email = null;
            //var response = instance.EmailPricePost(email);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailSendPost
        /// </summary>
        [Test]
        public void EmailSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Email email = null;
            //var response = instance.EmailSendPost(email);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
