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
    ///  Class for testing EmailDeliveryReceiptRulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EmailDeliveryReceiptRulesApiTests
    {
        private EmailDeliveryReceiptRulesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EmailDeliveryReceiptRulesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EmailDeliveryReceiptRulesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EmailDeliveryReceiptRulesApi
            //Assert.IsInstanceOfType(typeof(EmailDeliveryReceiptRulesApi), instance, "instance is a EmailDeliveryReceiptRulesApi");
        }

        
        /// <summary>
        /// Test EmailDeliveryReceiptAutomationDelete
        /// </summary>
        [Test]
        public void EmailDeliveryReceiptAutomationDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receiptRuleId = null;
            //var response = instance.EmailDeliveryReceiptAutomationDelete(receiptRuleId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailDeliveryReceiptAutomationGet
        /// </summary>
        [Test]
        public void EmailDeliveryReceiptAutomationGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receiptRuleId = null;
            //var response = instance.EmailDeliveryReceiptAutomationGet(receiptRuleId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailDeliveryReceiptAutomationPost
        /// </summary>
        [Test]
        public void EmailDeliveryReceiptAutomationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeliveryReceiptRule deliveryReceiptRule = null;
            //var response = instance.EmailDeliveryReceiptAutomationPost(deliveryReceiptRule);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailDeliveryReceiptAutomationPut
        /// </summary>
        [Test]
        public void EmailDeliveryReceiptAutomationPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receiptRuleId = null;
            //DeliveryReceiptRule deliveryReceiptRule = null;
            //var response = instance.EmailDeliveryReceiptAutomationPut(receiptRuleId, deliveryReceiptRule);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailDeliveryReceiptAutomationsGet
        /// </summary>
        [Test]
        public void EmailDeliveryReceiptAutomationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.EmailDeliveryReceiptAutomationsGet(q, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
