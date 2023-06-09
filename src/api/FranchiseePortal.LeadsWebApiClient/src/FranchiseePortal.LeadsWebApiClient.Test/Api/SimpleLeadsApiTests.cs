/*
 * Goddard iPaaS Leads API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Api;

namespace FranchiseePortal.LeadsWebApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing SimpleLeadsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SimpleLeadsApiTests : IDisposable
    {
        private SimpleLeadsApi instance;

        public SimpleLeadsApiTests()
        {
            instance = new SimpleLeadsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SimpleLeadsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SimpleLeadsApi
            //Assert.IsType<SimpleLeadsApi>(instance);
        }

        /// <summary>
        /// Test ApiV1SimpleLeadsPost
        /// </summary>
        [Fact]
        public void ApiV1SimpleLeadsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //instance.ApiV1SimpleLeadsPost(email);
        }
    }
}
