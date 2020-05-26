// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace httpInfrastructure
{
    internal partial class HttpRetryRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of HttpRetryRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public HttpRetryRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("http://localhost:3000");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateHead408Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Head;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/retry/408", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Return 408 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> Head408Async(CancellationToken cancellationToken = default)
        {
            using var message = CreateHead408Request();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Return 408 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Head408(CancellationToken cancellationToken = default)
        {
            using var message = CreateHead408Request();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePut500Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/retry/500", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(true);
            request.Content = content;
            return message;
        }

        /// <summary> Return 500 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> Put500Async(CancellationToken cancellationToken = default)
        {
            using var message = CreatePut500Request();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Return 500 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Put500(CancellationToken cancellationToken = default)
        {
            using var message = CreatePut500Request();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePatch500Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/retry/500", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(true);
            request.Content = content;
            return message;
        }

        /// <summary> Return 500 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> Patch500Async(CancellationToken cancellationToken = default)
        {
            using var message = CreatePatch500Request();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Return 500 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Patch500(CancellationToken cancellationToken = default)
        {
            using var message = CreatePatch500Request();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGet502Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/retry/502", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Return 502 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> Get502Async(CancellationToken cancellationToken = default)
        {
            using var message = CreateGet502Request();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Return 502 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Get502(CancellationToken cancellationToken = default)
        {
            using var message = CreateGet502Request();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateOptions502Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Options;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/retry/502", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Return 502 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<bool>> Options502Async(CancellationToken cancellationToken = default)
        {
            using var message = CreateOptions502Request();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        bool value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetBoolean();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Return 502 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<bool> Options502(CancellationToken cancellationToken = default)
        {
            using var message = CreateOptions502Request();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        bool value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetBoolean();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePost503Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/retry/503", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(true);
            request.Content = content;
            return message;
        }

        /// <summary> Return 503 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> Post503Async(CancellationToken cancellationToken = default)
        {
            using var message = CreatePost503Request();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Return 503 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Post503(CancellationToken cancellationToken = default)
        {
            using var message = CreatePost503Request();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDelete503Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/retry/503", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(true);
            request.Content = content;
            return message;
        }

        /// <summary> Return 503 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> Delete503Async(CancellationToken cancellationToken = default)
        {
            using var message = CreateDelete503Request();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Return 503 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete503(CancellationToken cancellationToken = default)
        {
            using var message = CreateDelete503Request();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePut504Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/retry/504", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(true);
            request.Content = content;
            return message;
        }

        /// <summary> Return 504 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> Put504Async(CancellationToken cancellationToken = default)
        {
            using var message = CreatePut504Request();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Return 504 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Put504(CancellationToken cancellationToken = default)
        {
            using var message = CreatePut504Request();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePatch504Request()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/retry/504", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(true);
            request.Content = content;
            return message;
        }

        /// <summary> Return 504 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> Patch504Async(CancellationToken cancellationToken = default)
        {
            using var message = CreatePatch504Request();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Return 504 status code, then 200 after retry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Patch504(CancellationToken cancellationToken = default)
        {
            using var message = CreatePatch504Request();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
