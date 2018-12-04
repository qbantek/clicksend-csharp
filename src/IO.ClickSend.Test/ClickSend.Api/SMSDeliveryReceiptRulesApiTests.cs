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
    ///  Class for testing SMSDeliveryReceiptRulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SMSDeliveryReceiptRulesApiTests
    {
        private SMSDeliveryReceiptRulesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SMSDeliveryReceiptRulesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SMSDeliveryReceiptRulesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SMSDeliveryReceiptRulesApi
            //Assert.IsInstanceOfType(typeof(SMSDeliveryReceiptRulesApi), instance, "instance is a SMSDeliveryReceiptRulesApi");
        }

        
        /// <summary>
        /// Test SmsDeliveryReceiptAutomationDelete
        /// </summary>
        [Test]
        public void SmsDeliveryReceiptAutomationDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receiptRuleId = null;
            //var response = instance.SmsDeliveryReceiptAutomationDelete(receiptRuleId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsDeliveryReceiptAutomationGet
        /// </summary>
        [Test]
        public void SmsDeliveryReceiptAutomationGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receiptRuleId = null;
            //var response = instance.SmsDeliveryReceiptAutomationGet(receiptRuleId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsDeliveryReceiptAutomationPost
        /// </summary>
        [Test]
        public void SmsDeliveryReceiptAutomationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeliveryReceiptRule deliveryReceiptRule = null;
            //var response = instance.SmsDeliveryReceiptAutomationPost(deliveryReceiptRule);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsDeliveryReceiptAutomationPut
        /// </summary>
        [Test]
        public void SmsDeliveryReceiptAutomationPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receiptRuleId = null;
            //DeliveryReceiptRule deliveryReceiptRule = null;
            //var response = instance.SmsDeliveryReceiptAutomationPut(receiptRuleId, deliveryReceiptRule);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsDeliveryReceiptAutomationsGet
        /// </summary>
        [Test]
        public void SmsDeliveryReceiptAutomationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.SmsDeliveryReceiptAutomationsGet(q, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
