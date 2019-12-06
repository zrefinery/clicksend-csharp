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
    ///  Class for testing SmsCampaignApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SmsCampaignApiTests
    {
        private SmsCampaignApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SmsCampaignApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SmsCampaignApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SmsCampaignApi
            //Assert.IsInstanceOfType(typeof(SmsCampaignApi), instance, "instance is a SmsCampaignApi");
        }

        
        /// <summary>
        /// Test SmsCampaignBySmsCampaignIdGet
        /// </summary>
        [Test]
        public void SmsCampaignBySmsCampaignIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? smsCampaignId = null;
            //var response = instance.SmsCampaignBySmsCampaignIdGet(smsCampaignId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsCampaignsBySmsCampaignIdPut
        /// </summary>
        [Test]
        public void SmsCampaignsBySmsCampaignIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? smsCampaignId = null;
            //SmsCampaign campaign = null;
            //var response = instance.SmsCampaignsBySmsCampaignIdPut(smsCampaignId, campaign);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsCampaignsCancelBySmsCampaignIdPut
        /// </summary>
        [Test]
        public void SmsCampaignsCancelBySmsCampaignIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? smsCampaignId = null;
            //var response = instance.SmsCampaignsCancelBySmsCampaignIdPut(smsCampaignId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsCampaignsGet
        /// </summary>
        [Test]
        public void SmsCampaignsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.SmsCampaignsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsCampaignsPricePost
        /// </summary>
        [Test]
        public void SmsCampaignsPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SmsCampaign campaign = null;
            //var response = instance.SmsCampaignsPricePost(campaign);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SmsCampaignsSendPost
        /// </summary>
        [Test]
        public void SmsCampaignsSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SmsCampaign campaign = null;
            //var response = instance.SmsCampaignsSendPost(campaign);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
