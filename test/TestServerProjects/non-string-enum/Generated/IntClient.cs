// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using non_string_enum.Models;

namespace non_string_enum
{
    /// <summary> The Int service client. </summary>
    public partial class IntClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal IntRestClient RestClient { get; }
        /// <summary> Initializes a new instance of IntClient for mocking. </summary>
        protected IntClient()
        {
        }
        /// <summary> Initializes a new instance of IntClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal IntClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new IntRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Put an int enum. </summary>
        /// <param name="input"> Input int enum. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> PutAsync(IntEnum? input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IntClient.Put");
            scope.Start();
            try
            {
                return await RestClient.PutAsync(input, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put an int enum. </summary>
        /// <param name="input"> Input int enum. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> Put(IntEnum? input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IntClient.Put");
            scope.Start();
            try
            {
                return RestClient.Put(input, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an int enum. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IntEnum>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IntClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an int enum. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IntEnum> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IntClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
