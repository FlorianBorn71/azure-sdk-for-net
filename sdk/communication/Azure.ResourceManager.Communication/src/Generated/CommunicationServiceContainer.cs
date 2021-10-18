// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Communication.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Communication
{
    /// <summary> A class representing collection of CommunicationService and their operations over a ResourceGroup. </summary>
    public partial class CommunicationServiceContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CommunicationServiceRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="CommunicationServiceContainer"/> class for mocking. </summary>
        protected CommunicationServiceContainer()
        {
        }

        /// <summary> Initializes a new instance of CommunicationServiceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CommunicationServiceContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new CommunicationServiceRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Create a new CommunicationService or update an existing CommunicationService. </summary>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="parameters"> Parameters for the create or update operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationServiceName"/> is null. </exception>
        public virtual CommunicationServiceCreateOrUpdateOperation CreateOrUpdate(string communicationServiceName, CommunicationServiceData parameters = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (communicationServiceName == null)
            {
                throw new ArgumentNullException(nameof(communicationServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, communicationServiceName, parameters, cancellationToken);
                var operation = new CommunicationServiceCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, communicationServiceName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a new CommunicationService or update an existing CommunicationService. </summary>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="parameters"> Parameters for the create or update operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationServiceName"/> is null. </exception>
        public async virtual Task<CommunicationServiceCreateOrUpdateOperation> CreateOrUpdateAsync(string communicationServiceName, CommunicationServiceData parameters = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (communicationServiceName == null)
            {
                throw new ArgumentNullException(nameof(communicationServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, communicationServiceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new CommunicationServiceCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, communicationServiceName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<CommunicationService> Get(string communicationServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.Get");
            scope.Start();
            try
            {
                if (communicationServiceName == null)
                {
                    throw new ArgumentNullException(nameof(communicationServiceName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, communicationServiceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CommunicationService(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<CommunicationService>> GetAsync(string communicationServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.Get");
            scope.Start();
            try
            {
                if (communicationServiceName == null)
                {
                    throw new ArgumentNullException(nameof(communicationServiceName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, communicationServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CommunicationService(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<CommunicationService> GetIfExists(string communicationServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (communicationServiceName == null)
                {
                    throw new ArgumentNullException(nameof(communicationServiceName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, communicationServiceName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<CommunicationService>(null, response.GetRawResponse())
                    : Response.FromValue(new CommunicationService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<CommunicationService>> GetIfExistsAsync(string communicationServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (communicationServiceName == null)
                {
                    throw new ArgumentNullException(nameof(communicationServiceName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, communicationServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<CommunicationService>(null, response.GetRawResponse())
                    : Response.FromValue(new CommunicationService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string communicationServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (communicationServiceName == null)
                {
                    throw new ArgumentNullException(nameof(communicationServiceName));
                }

                var response = GetIfExists(communicationServiceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string communicationServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (communicationServiceName == null)
                {
                    throw new ArgumentNullException(nameof(communicationServiceName));
                }

                var response = await GetIfExistsAsync(communicationServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Handles requests to list all resources in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CommunicationService" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CommunicationService> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CommunicationService> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CommunicationService(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CommunicationService> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CommunicationService(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Handles requests to list all resources in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CommunicationService" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CommunicationService> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CommunicationService>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CommunicationService(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CommunicationService>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CommunicationService(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="CommunicationService" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(CommunicationService.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="CommunicationService" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(CommunicationService.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, CommunicationService, CommunicationServiceData> Construct() { }
    }
}
