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
    ///  Class for testing EmailMarketingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EmailMarketingApiTests
    {
        private EmailMarketingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EmailMarketingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EmailMarketingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EmailMarketingApi
            //Assert.IsInstanceOfType(typeof(EmailMarketingApi), instance, "instance is a EmailMarketingApi");
        }

        
        /// <summary>
        /// Test AllowedEmailAddressGet
        /// </summary>
        [Test]
        public void AllowedEmailAddressGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.AllowedEmailAddressGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test AllowedEmailAddressPost
        /// </summary>
        [Test]
        public void AllowedEmailAddressPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailAddress emailAddress = null;
            //var response = instance.AllowedEmailAddressPost(emailAddress);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test CancelEmailCampaignPut
        /// </summary>
        [Test]
        public void CancelEmailCampaignPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailCampaignId = null;
            //var response = instance.CancelEmailCampaignPut(emailCampaignId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailCampaignGet
        /// </summary>
        [Test]
        public void EmailCampaignGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailCampaignId = null;
            //var response = instance.EmailCampaignGet(emailCampaignId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailCampaignHistoryExportGet
        /// </summary>
        [Test]
        public void EmailCampaignHistoryExportGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailCampaignId = null;
            //int? dateFrom = null;
            //int? dateTo = null;
            //var response = instance.EmailCampaignHistoryExportGet(emailCampaignId, dateFrom, dateTo);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailCampaignHistoryGet
        /// </summary>
        [Test]
        public void EmailCampaignHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailCampaignId = null;
            //int? dateFrom = null;
            //int? dateTo = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.EmailCampaignHistoryGet(emailCampaignId, dateFrom, dateTo, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailCampaignPost
        /// </summary>
        [Test]
        public void EmailCampaignPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailCampaign emailCampaign = null;
            //var response = instance.EmailCampaignPost(emailCampaign);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailCampaignPricePost
        /// </summary>
        [Test]
        public void EmailCampaignPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailCampaign emailCampaign = null;
            //var response = instance.EmailCampaignPricePost(emailCampaign);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailCampaignPut
        /// </summary>
        [Test]
        public void EmailCampaignPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailCampaignId = null;
            //EmailCampaign emailCampaign = null;
            //var response = instance.EmailCampaignPut(emailCampaignId, emailCampaign);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailCampaignsGet
        /// </summary>
        [Test]
        public void EmailCampaignsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.EmailCampaignsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SendVerificationTokenGet
        /// </summary>
        [Test]
        public void SendVerificationTokenGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailAddressId = null;
            //var response = instance.SendVerificationTokenGet(emailAddressId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SpecificAllowedEmailAddressDelete
        /// </summary>
        [Test]
        public void SpecificAllowedEmailAddressDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailAddressId = null;
            //var response = instance.SpecificAllowedEmailAddressDelete(emailAddressId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SpecificAllowedEmailAddressGet
        /// </summary>
        [Test]
        public void SpecificAllowedEmailAddressGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailAddressId = null;
            //var response = instance.SpecificAllowedEmailAddressGet(emailAddressId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VerifyAllowedEmailAddressGet
        /// </summary>
        [Test]
        public void VerifyAllowedEmailAddressGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailAddressId = null;
            //string activationToken = null;
            //var response = instance.VerifyAllowedEmailAddressGet(emailAddressId, activationToken);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
