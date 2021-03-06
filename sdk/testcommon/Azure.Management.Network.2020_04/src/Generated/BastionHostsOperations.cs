// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The BastionHosts service client. </summary>
    public partial class BastionHostsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal BastionHostsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of BastionHostsOperations for mocking. </summary>
        protected BastionHostsOperations()
        {
        }
        /// <summary> Initializes a new instance of BastionHostsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal BastionHostsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new BastionHostsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified Bastion Host. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BastionHost>> GetAsync(string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, bastionHostName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Bastion Host. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BastionHost> Get(string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, bastionHostName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Bastion Hosts in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<BastionHost> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BastionHost>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BastionHost>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Bastion Hosts in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<BastionHost> List(CancellationToken cancellationToken = default)
        {
            Page<BastionHost> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BastionHost> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Bastion Hosts in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<BastionHost> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<BastionHost>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BastionHost>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Bastion Hosts in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<BastionHost> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<BastionHost> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BastionHost> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified Bastion Host. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<BastionHostsDeleteOperation> StartDeleteAsync(string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, bastionHostName, cancellationToken).ConfigureAwait(false);
                return new BastionHostsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, bastionHostName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified Bastion Host. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual BastionHostsDeleteOperation StartDelete(string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, bastionHostName, cancellationToken);
                return new BastionHostsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, bastionHostName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Bastion Host. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Bastion Host operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<BastionHostsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string bastionHostName, BastionHost parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, bastionHostName, parameters, cancellationToken).ConfigureAwait(false);
                return new BastionHostsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, bastionHostName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Bastion Host. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Bastion Host operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual BastionHostsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string bastionHostName, BastionHost parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BastionHostsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, bastionHostName, parameters, cancellationToken);
                return new BastionHostsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, bastionHostName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
