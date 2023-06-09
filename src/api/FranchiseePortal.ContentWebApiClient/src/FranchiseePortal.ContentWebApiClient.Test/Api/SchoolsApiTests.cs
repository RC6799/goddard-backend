/*
 * Goddard.ContentWebApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
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

using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Api;
// uncomment below to import models
//using FranchiseePortal.ContentWebApiClient.Model;

namespace FranchiseePortal.ContentWebApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing SchoolsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SchoolsApiTests : IDisposable
    {
        private SchoolsApi instance;

        public SchoolsApiTests()
        {
            instance = new SchoolsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SchoolsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SchoolsApi
            //Assert.IsType<SchoolsApi>(instance);
        }

        /// <summary>
        /// Test ApiV1DcpSchoolsCrmIdPublishPost
        /// </summary>
        [Fact]
        public void ApiV1DcpSchoolsCrmIdPublishPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string crmId = null;
            //instance.ApiV1DcpSchoolsCrmIdPublishPost(crmId);
        }

        /// <summary>
        /// Test ApiV1DcpSchoolsCrmIdSchoolHeroImagePut
        /// </summary>
        [Fact]
        public void ApiV1DcpSchoolsCrmIdSchoolHeroImagePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string crmId = null;
            //SchoolsUpdateRequest schoolsUpdateRequest = null;
            //var response = instance.ApiV1DcpSchoolsCrmIdSchoolHeroImagePut(crmId, schoolsUpdateRequest);
            //Assert.IsType<SchoolsUpdateResponse>(response);
        }

        /// <summary>
        /// Test ApiV1DcpSchoolsGet
        /// </summary>
        [Fact]
        public void ApiV1DcpSchoolsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string crmId = null;
            //var response = instance.ApiV1DcpSchoolsGet(crmId);
            //Assert.IsType<SchoolInfoResponse>(response);
        }
    }
}
