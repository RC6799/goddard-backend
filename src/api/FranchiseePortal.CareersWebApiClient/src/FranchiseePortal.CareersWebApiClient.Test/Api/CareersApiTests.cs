/*
 * Goddard.Careers
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

using FranchiseePortal.CareersWebApiClient.Client;
using FranchiseePortal.CareersWebApiClient.Api;
// uncomment below to import models
//using FranchiseePortal.CareersWebApiClient.Model;

namespace FranchiseePortal.CareersWebApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing CareersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CareersApiTests : IDisposable
    {
        private CareersApi instance;

        public CareersApiTests()
        {
            instance = new CareersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CareersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CareersApi
            //Assert.IsType<CareersApi>(instance);
        }

        /// <summary>
        /// Test CareersCareerIdDelete
        /// </summary>
        [Fact]
        public void CareersCareerIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long careerId = null;
            //var response = instance.CareersCareerIdDelete(careerId);
            //Assert.IsType<Career>(response);
        }

        /// <summary>
        /// Test CareersCareerIdGet
        /// </summary>
        [Fact]
        public void CareersCareerIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long careerId = null;
            //var response = instance.CareersCareerIdGet(careerId);
            //Assert.IsType<Career>(response);
        }

        /// <summary>
        /// Test CareersGet
        /// </summary>
        [Fact]
        public void CareersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CareersGet();
            //Assert.IsType<List<Career>>(response);
        }

        /// <summary>
        /// Test CareersGetCareersBySchoolIdSchoolIdGet
        /// </summary>
        [Fact]
        public void CareersGetCareersBySchoolIdSchoolIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string schoolId = null;
            //var response = instance.CareersGetCareersBySchoolIdSchoolIdGet(schoolId);
            //Assert.IsType<List<Career>>(response);
        }

        /// <summary>
        /// Test CareersPost
        /// </summary>
        [Fact]
        public void CareersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Career career = null;
            //var response = instance.CareersPost(career);
            //Assert.IsType<Career>(response);
        }
    }
}
