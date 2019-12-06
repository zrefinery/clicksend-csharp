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
    ///  Class for testing SubaccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SubaccountApiTests
    {
        private SubaccountApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubaccountApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubaccountApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SubaccountApi
            //Assert.IsInstanceOfType(typeof(SubaccountApi), instance, "instance is a SubaccountApi");
        }

        
        /// <summary>
        /// Test SubaccountsBySubaccountIdDelete
        /// </summary>
        [Test]
        public void SubaccountsBySubaccountIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? subaccountId = null;
            //var response = instance.SubaccountsBySubaccountIdDelete(subaccountId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SubaccountsBySubaccountIdGet
        /// </summary>
        [Test]
        public void SubaccountsBySubaccountIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? subaccountId = null;
            //var response = instance.SubaccountsBySubaccountIdGet(subaccountId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SubaccountsBySubaccountIdPut
        /// </summary>
        [Test]
        public void SubaccountsBySubaccountIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? subaccountId = null;
            //Subaccount subaccount = null;
            //var response = instance.SubaccountsBySubaccountIdPut(subaccountId, subaccount);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SubaccountsGet
        /// </summary>
        [Test]
        public void SubaccountsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.SubaccountsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SubaccountsPost
        /// </summary>
        [Test]
        public void SubaccountsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Subaccount subaccount = null;
            //var response = instance.SubaccountsPost(subaccount);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SubaccountsRegenApiKeyBySubaccountIdPut
        /// </summary>
        [Test]
        public void SubaccountsRegenApiKeyBySubaccountIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? subaccountId = null;
            //var response = instance.SubaccountsRegenApiKeyBySubaccountIdPut(subaccountId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
