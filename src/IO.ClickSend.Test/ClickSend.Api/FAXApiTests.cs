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

using IO.Swagger.Client;
using IO.Swagger.ClickSend.Api;
using IO.Swagger.ClickSend.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing FAXApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FAXApiTests
    {
        private FAXApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FAXApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FAXApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FAXApi
            //Assert.IsInstanceOfType(typeof(FAXApi), instance, "instance is a FAXApi");
        }

        
        /// <summary>
        /// Test FaxHistoryGet
        /// </summary>
        [Test]
        public void FaxHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? dateFrom = null;
            //int? dateTo = null;
            //string q = null;
            //string order = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.FaxHistoryGet(dateFrom, dateTo, q, order, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test FaxPricePost
        /// </summary>
        [Test]
        public void FaxPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FaxMessageCollection faxMessage = null;
            //var response = instance.FaxPricePost(faxMessage);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test FaxReceiptsByMessageIdGet
        /// </summary>
        [Test]
        public void FaxReceiptsByMessageIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string messageId = null;
            //var response = instance.FaxReceiptsByMessageIdGet(messageId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test FaxReceiptsGet
        /// </summary>
        [Test]
        public void FaxReceiptsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.FaxReceiptsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test FaxReceiptsPost
        /// </summary>
        [Test]
        public void FaxReceiptsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Url url = null;
            //var response = instance.FaxReceiptsPost(url);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test FaxReceiptsReadPut
        /// </summary>
        [Test]
        public void FaxReceiptsReadPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateBefore dateBefore = null;
            //var response = instance.FaxReceiptsReadPut(dateBefore);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test FaxSendPost
        /// </summary>
        [Test]
        public void FaxSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FaxMessageCollection faxMessage = null;
            //var response = instance.FaxSendPost(faxMessage);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
