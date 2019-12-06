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
    ///  Class for testing DeliveryIssuesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DeliveryIssuesApiTests
    {
        private DeliveryIssuesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DeliveryIssuesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DeliveryIssuesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DeliveryIssuesApi
            //Assert.IsInstanceOfType(typeof(DeliveryIssuesApi), instance, "instance is a DeliveryIssuesApi");
        }

        
        /// <summary>
        /// Test DeliveryIssuesGet
        /// </summary>
        [Test]
        public void DeliveryIssuesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.DeliveryIssuesGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeliveryIssuesPost
        /// </summary>
        [Test]
        public void DeliveryIssuesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeliveryIssue deliveryIssue = null;
            //var response = instance.DeliveryIssuesPost(deliveryIssue);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
