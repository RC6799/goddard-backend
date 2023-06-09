/*
 * Goddard iPaaS Leads API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using FranchiseePortal.LeadsWebApiClient.Client;

namespace FranchiseePortal.LeadsWebApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISimpleLeadsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="FranchiseePortal.LeadsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ApiV1SimpleLeadsPost(string email = default(string), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.LeadsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApiV1SimpleLeadsPostWithHttpInfo(string email = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISimpleLeadsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.LeadsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiV1SimpleLeadsPostAsync(string email = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.LeadsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiV1SimpleLeadsPostWithHttpInfoAsync(string email = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISimpleLeadsApi : ISimpleLeadsApiSync, ISimpleLeadsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SimpleLeadsApi : ISimpleLeadsApi
    {
        private FranchiseePortal.LeadsWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleLeadsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SimpleLeadsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleLeadsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SimpleLeadsApi(string basePath)
        {
            this.Configuration = FranchiseePortal.LeadsWebApiClient.Client.Configuration.MergeConfigurations(
                FranchiseePortal.LeadsWebApiClient.Client.GlobalConfiguration.Instance,
                new FranchiseePortal.LeadsWebApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new FranchiseePortal.LeadsWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FranchiseePortal.LeadsWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = FranchiseePortal.LeadsWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleLeadsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SimpleLeadsApi(FranchiseePortal.LeadsWebApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = FranchiseePortal.LeadsWebApiClient.Client.Configuration.MergeConfigurations(
                FranchiseePortal.LeadsWebApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new FranchiseePortal.LeadsWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FranchiseePortal.LeadsWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = FranchiseePortal.LeadsWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleLeadsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SimpleLeadsApi(FranchiseePortal.LeadsWebApiClient.Client.ISynchronousClient client, FranchiseePortal.LeadsWebApiClient.Client.IAsynchronousClient asyncClient, FranchiseePortal.LeadsWebApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = FranchiseePortal.LeadsWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public FranchiseePortal.LeadsWebApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public FranchiseePortal.LeadsWebApiClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public FranchiseePortal.LeadsWebApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FranchiseePortal.LeadsWebApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.LeadsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ApiV1SimpleLeadsPost(string email = default(string), int operationIndex = 0)
        {
            ApiV1SimpleLeadsPostWithHttpInfo(email);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.LeadsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public FranchiseePortal.LeadsWebApiClient.Client.ApiResponse<Object> ApiV1SimpleLeadsPostWithHttpInfo(string email = default(string), int operationIndex = 0)
        {
            FranchiseePortal.LeadsWebApiClient.Client.RequestOptions localVarRequestOptions = new FranchiseePortal.LeadsWebApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = FranchiseePortal.LeadsWebApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FranchiseePortal.LeadsWebApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (email != null)
            {
                localVarRequestOptions.FormParameters.Add("email", FranchiseePortal.LeadsWebApiClient.Client.ClientUtils.ParameterToString(email)); // form parameter
            }

            localVarRequestOptions.Operation = "SimpleLeadsApi.ApiV1SimpleLeadsPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("Ocp-Apim-Subscription-Key", this.Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/api/v1/simple-leads", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1SimpleLeadsPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.LeadsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiV1SimpleLeadsPostAsync(string email = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ApiV1SimpleLeadsPostWithHttpInfoAsync(email, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.LeadsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<FranchiseePortal.LeadsWebApiClient.Client.ApiResponse<Object>> ApiV1SimpleLeadsPostWithHttpInfoAsync(string email = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            FranchiseePortal.LeadsWebApiClient.Client.RequestOptions localVarRequestOptions = new FranchiseePortal.LeadsWebApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = FranchiseePortal.LeadsWebApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FranchiseePortal.LeadsWebApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (email != null)
            {
                localVarRequestOptions.FormParameters.Add("email", FranchiseePortal.LeadsWebApiClient.Client.ClientUtils.ParameterToString(email)); // form parameter
            }

            localVarRequestOptions.Operation = "SimpleLeadsApi.ApiV1SimpleLeadsPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("Ocp-Apim-Subscription-Key", this.Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/api/v1/simple-leads", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1SimpleLeadsPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
