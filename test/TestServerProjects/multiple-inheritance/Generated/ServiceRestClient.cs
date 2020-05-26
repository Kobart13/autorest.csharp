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
using multiple_inheritance.Models;

namespace multiple_inheritance
{
    internal partial class ServiceRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ServiceRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public ServiceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("http://localhost:3000");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetHorseRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/multipleInheritance/horse", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get a horse with name &apos;Fred&apos; and isAShowHorse true. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Horse>> GetHorseAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetHorseRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Horse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = Horse.DeserializeHorse(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a horse with name &apos;Fred&apos; and isAShowHorse true. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Horse> GetHorse(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetHorseRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Horse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = Horse.DeserializeHorse(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutHorseRequest(Horse horse)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/multipleInheritance/horse", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(horse);
            request.Content = content;
            return message;
        }

        /// <summary> Put a horse with name &apos;General&apos; and isAShowHorse false. </summary>
        /// <param name="horse"> Put a horse with name &apos;General&apos; and isAShowHorse false. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<string>> PutHorseAsync(Horse horse, CancellationToken cancellationToken = default)
        {
            if (horse == null)
            {
                throw new ArgumentNullException(nameof(horse));
            }

            using var message = CreatePutHorseRequest(horse);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = document.RootElement.GetString();
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put a horse with name &apos;General&apos; and isAShowHorse false. </summary>
        /// <param name="horse"> Put a horse with name &apos;General&apos; and isAShowHorse false. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<string> PutHorse(Horse horse, CancellationToken cancellationToken = default)
        {
            if (horse == null)
            {
                throw new ArgumentNullException(nameof(horse));
            }

            using var message = CreatePutHorseRequest(horse);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = document.RootElement.GetString();
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetPetRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/multipleInheritance/pet", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get a pet with name &apos;Peanut&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Pet>> GetPetAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetPetRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Pet value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = Pet.DeserializePet(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a pet with name &apos;Peanut&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Pet> GetPet(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetPetRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Pet value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = Pet.DeserializePet(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutPetRequest(Pet pet)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/multipleInheritance/pet", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(pet);
            request.Content = content;
            return message;
        }

        /// <summary> Put a pet with name &apos;Butter&apos;. </summary>
        /// <param name="pet"> Put a pet with name &apos;Butter&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<string>> PutPetAsync(Pet pet, CancellationToken cancellationToken = default)
        {
            if (pet == null)
            {
                throw new ArgumentNullException(nameof(pet));
            }

            using var message = CreatePutPetRequest(pet);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = document.RootElement.GetString();
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put a pet with name &apos;Butter&apos;. </summary>
        /// <param name="pet"> Put a pet with name &apos;Butter&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<string> PutPet(Pet pet, CancellationToken cancellationToken = default)
        {
            if (pet == null)
            {
                throw new ArgumentNullException(nameof(pet));
            }

            using var message = CreatePutPetRequest(pet);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = document.RootElement.GetString();
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetFelineRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/multipleInheritance/feline", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get a feline where meows and hisses are true. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Feline>> GetFelineAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetFelineRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Feline value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = Feline.DeserializeFeline(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a feline where meows and hisses are true. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Feline> GetFeline(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetFelineRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Feline value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = Feline.DeserializeFeline(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutFelineRequest(Feline feline)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/multipleInheritance/feline", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(feline);
            request.Content = content;
            return message;
        }

        /// <summary> Put a feline who hisses and doesn&apos;t meow. </summary>
        /// <param name="feline"> Put a feline who hisses and doesn&apos;t meow. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<string>> PutFelineAsync(Feline feline, CancellationToken cancellationToken = default)
        {
            if (feline == null)
            {
                throw new ArgumentNullException(nameof(feline));
            }

            using var message = CreatePutFelineRequest(feline);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = document.RootElement.GetString();
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put a feline who hisses and doesn&apos;t meow. </summary>
        /// <param name="feline"> Put a feline who hisses and doesn&apos;t meow. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<string> PutFeline(Feline feline, CancellationToken cancellationToken = default)
        {
            if (feline == null)
            {
                throw new ArgumentNullException(nameof(feline));
            }

            using var message = CreatePutFelineRequest(feline);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = document.RootElement.GetString();
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetCatRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/multipleInheritance/cat", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get a cat with name &apos;Whiskers&apos; where likesMilk, meows, and hisses is true. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Cat>> GetCatAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetCatRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Cat value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = Cat.DeserializeCat(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a cat with name &apos;Whiskers&apos; where likesMilk, meows, and hisses is true. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Cat> GetCat(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetCatRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Cat value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = Cat.DeserializeCat(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutCatRequest(Cat cat)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/multipleInheritance/cat", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(cat);
            request.Content = content;
            return message;
        }

        /// <summary> Put a cat with name &apos;Boots&apos; where likesMilk and hisses is false, meows is true. </summary>
        /// <param name="cat"> Put a cat with name &apos;Boots&apos; where likesMilk and hisses is false, meows is true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<string>> PutCatAsync(Cat cat, CancellationToken cancellationToken = default)
        {
            if (cat == null)
            {
                throw new ArgumentNullException(nameof(cat));
            }

            using var message = CreatePutCatRequest(cat);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = document.RootElement.GetString();
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put a cat with name &apos;Boots&apos; where likesMilk and hisses is false, meows is true. </summary>
        /// <param name="cat"> Put a cat with name &apos;Boots&apos; where likesMilk and hisses is false, meows is true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<string> PutCat(Cat cat, CancellationToken cancellationToken = default)
        {
            if (cat == null)
            {
                throw new ArgumentNullException(nameof(cat));
            }

            using var message = CreatePutCatRequest(cat);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = document.RootElement.GetString();
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetKittenRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/multipleInheritance/kitten", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get a kitten with name &apos;Gatito&apos; where likesMilk and meows is true, and hisses and eatsMiceYet is false. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Kitten>> GetKittenAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetKittenRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Kitten value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = Kitten.DeserializeKitten(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a kitten with name &apos;Gatito&apos; where likesMilk and meows is true, and hisses and eatsMiceYet is false. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Kitten> GetKitten(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetKittenRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Kitten value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = Kitten.DeserializeKitten(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutKittenRequest(Kitten kitten)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/multipleInheritance/kitten", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(kitten);
            request.Content = content;
            return message;
        }

        /// <summary> Put a kitten with name &apos;Kitty&apos; where likesMilk and hisses is false, meows and eatsMiceYet is true. </summary>
        /// <param name="kitten"> Put a kitten with name &apos;Kitty&apos; where likesMilk and hisses is false, meows and eatsMiceYet is true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<string>> PutKittenAsync(Kitten kitten, CancellationToken cancellationToken = default)
        {
            if (kitten == null)
            {
                throw new ArgumentNullException(nameof(kitten));
            }

            using var message = CreatePutKittenRequest(kitten);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = document.RootElement.GetString();
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put a kitten with name &apos;Kitty&apos; where likesMilk and hisses is false, meows and eatsMiceYet is true. </summary>
        /// <param name="kitten"> Put a kitten with name &apos;Kitty&apos; where likesMilk and hisses is false, meows and eatsMiceYet is true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<string> PutKitten(Kitten kitten, CancellationToken cancellationToken = default)
        {
            if (kitten == null)
            {
                throw new ArgumentNullException(nameof(kitten));
            }

            using var message = CreatePutKittenRequest(kitten);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = document.RootElement.GetString();
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
