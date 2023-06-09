/*
 * Goddard.ContentWebApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace FranchiseePortal.ContentWebApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITooltipsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="FranchiseePortal.ContentWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cfParentPath"></param>
        /// <param name="cfName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TooltipDto</returns>
        TooltipDto ApiV1DcpTooltipsGet(string cfParentPath, string cfName, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.ContentWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cfParentPath"></param>
        /// <param name="cfName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TooltipDto</returns>
        ApiResponse<TooltipDto> ApiV1DcpTooltipsGetWithHttpInfo(string cfParentPath, string cfName, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITooltipsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.ContentWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cfParentPath"></param>
        /// <param name="cfName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TooltipDto</returns>
        System.Threading.Tasks.Task<TooltipDto> ApiV1DcpTooltipsGetAsync(string cfParentPath, string cfName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.ContentWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cfParentPath"></param>
        /// <param name="cfName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TooltipDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<TooltipDto>> ApiV1DcpTooltipsGetWithHttpInfoAsync(string cfParentPath, string cfName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITooltipsApi : ITooltipsApiSync, ITooltipsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TooltipsApi : ITooltipsApi
    {
        private FranchiseePortal.ContentWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TooltipsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TooltipsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TooltipsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TooltipsApi(string basePath)
        {
            this.Configuration = FranchiseePortal.ContentWebApiClient.Client.Configuration.MergeConfigurations(
                FranchiseePortal.ContentWebApiClient.Client.GlobalConfiguration.Instance,
                new FranchiseePortal.ContentWebApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new FranchiseePortal.ContentWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FranchiseePortal.ContentWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = FranchiseePortal.ContentWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TooltipsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TooltipsApi(FranchiseePortal.ContentWebApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = FranchiseePortal.ContentWebApiClient.Client.Configuration.MergeConfigurations(
                FranchiseePortal.ContentWebApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new FranchiseePortal.ContentWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FranchiseePortal.ContentWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = FranchiseePortal.ContentWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TooltipsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TooltipsApi(FranchiseePortal.ContentWebApiClient.Client.ISynchronousClient client, FranchiseePortal.ContentWebApiClient.Client.IAsynchronousClient asyncClient, FranchiseePortal.ContentWebApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = FranchiseePortal.ContentWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public FranchiseePortal.ContentWebApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public FranchiseePortal.ContentWebApiClient.Client.ISynchronousClient Client { get; set; }

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
        public FranchiseePortal.ContentWebApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FranchiseePortal.ContentWebApiClient.Client.ExceptionFactory ExceptionFactory
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
        /// <exception cref="FranchiseePortal.ContentWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cfParentPath"></param>
        /// <param name="cfName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TooltipDto</returns>
        public TooltipDto ApiV1DcpTooltipsGet(string cfParentPath, string cfName, int operationIndex = 0)
        {
            FranchiseePortal.ContentWebApiClient.Client.ApiResponse<TooltipDto> localVarResponse = ApiV1DcpTooltipsGetWithHttpInfo(cfParentPath, cfName);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.ContentWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cfParentPath"></param>
        /// <param name="cfName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TooltipDto</returns>
        public FranchiseePortal.ContentWebApiClient.Client.ApiResponse<TooltipDto> ApiV1DcpTooltipsGetWithHttpInfo(string cfParentPath, string cfName, int operationIndex = 0)
        {
            // verify the required parameter 'cfParentPath' is set
            if (cfParentPath == null)
            {
                throw new FranchiseePortal.ContentWebApiClient.Client.ApiException(400, "Missing required parameter 'cfParentPath' when calling TooltipsApi->ApiV1DcpTooltipsGet");
            }

            // verify the required parameter 'cfName' is set
            if (cfName == null)
            {
                throw new FranchiseePortal.ContentWebApiClient.Client.ApiException(400, "Missing required parameter 'cfName' when calling TooltipsApi->ApiV1DcpTooltipsGet");
            }

            FranchiseePortal.ContentWebApiClient.Client.RequestOptions localVarRequestOptions = new FranchiseePortal.ContentWebApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = FranchiseePortal.ContentWebApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FranchiseePortal.ContentWebApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(FranchiseePortal.ContentWebApiClient.Client.ClientUtils.ParameterToMultiMap("", "cfParentPath", cfParentPath));
            localVarRequestOptions.QueryParameters.Add(FranchiseePortal.ContentWebApiClient.Client.ClientUtils.ParameterToMultiMap("", "cfName", cfName));

            localVarRequestOptions.Operation = "TooltipsApi.ApiV1DcpTooltipsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<TooltipDto>("/api/v1/dcp/tooltips", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1DcpTooltipsGet", localVarResponse);
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
        /// <exception cref="FranchiseePortal.ContentWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cfParentPath"></param>
        /// <param name="cfName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TooltipDto</returns>
        public async System.Threading.Tasks.Task<TooltipDto> ApiV1DcpTooltipsGetAsync(string cfParentPath, string cfName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FranchiseePortal.ContentWebApiClient.Client.ApiResponse<TooltipDto> localVarResponse = await ApiV1DcpTooltipsGetWithHttpInfoAsync(cfParentPath, cfName, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.ContentWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cfParentPath"></param>
        /// <param name="cfName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TooltipDto)</returns>
        public async System.Threading.Tasks.Task<FranchiseePortal.ContentWebApiClient.Client.ApiResponse<TooltipDto>> ApiV1DcpTooltipsGetWithHttpInfoAsync(string cfParentPath, string cfName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cfParentPath' is set
            if (cfParentPath == null)
            {
                throw new FranchiseePortal.ContentWebApiClient.Client.ApiException(400, "Missing required parameter 'cfParentPath' when calling TooltipsApi->ApiV1DcpTooltipsGet");
            }

            // verify the required parameter 'cfName' is set
            if (cfName == null)
            {
                throw new FranchiseePortal.ContentWebApiClient.Client.ApiException(400, "Missing required parameter 'cfName' when calling TooltipsApi->ApiV1DcpTooltipsGet");
            }


            FranchiseePortal.ContentWebApiClient.Client.RequestOptions localVarRequestOptions = new FranchiseePortal.ContentWebApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = FranchiseePortal.ContentWebApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FranchiseePortal.ContentWebApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(FranchiseePortal.ContentWebApiClient.Client.ClientUtils.ParameterToMultiMap("", "cfParentPath", cfParentPath));
            localVarRequestOptions.QueryParameters.Add(FranchiseePortal.ContentWebApiClient.Client.ClientUtils.ParameterToMultiMap("", "cfName", cfName));

            localVarRequestOptions.Operation = "TooltipsApi.ApiV1DcpTooltipsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<TooltipDto>("/api/v1/dcp/tooltips", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1DcpTooltipsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
