// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagedVirtualNetworksOperations.
    /// </summary>
    public static partial class ManagedVirtualNetworksOperationsExtensions
    {
            /// <summary>
            /// Lists managed Virtual Networks.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            public static IPage<ManagedVirtualNetworkResource> ListByFactory(this IManagedVirtualNetworksOperations operations, string resourceGroupName, string factoryName)
            {
                return operations.ListByFactoryAsync(resourceGroupName, factoryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists managed Virtual Networks.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedVirtualNetworkResource>> ListByFactoryAsync(this IManagedVirtualNetworksOperations operations, string resourceGroupName, string factoryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFactoryWithHttpMessagesAsync(resourceGroupName, factoryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a managed Virtual Network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='managedVirtualNetworkName'>
            /// Managed virtual network name
            /// </param>
            /// <param name='managedVirtualNetwork'>
            /// Managed Virtual Network resource definition.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the managed Virtual Network entity. Should only be specified for
            /// update, for which it should match existing entity or can be * for
            /// unconditional update.
            /// </param>
            public static ManagedVirtualNetworkResource CreateOrUpdate(this IManagedVirtualNetworksOperations operations, string resourceGroupName, string factoryName, string managedVirtualNetworkName, ManagedVirtualNetworkResource managedVirtualNetwork, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, factoryName, managedVirtualNetworkName, managedVirtualNetwork, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a managed Virtual Network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='managedVirtualNetworkName'>
            /// Managed virtual network name
            /// </param>
            /// <param name='managedVirtualNetwork'>
            /// Managed Virtual Network resource definition.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the managed Virtual Network entity. Should only be specified for
            /// update, for which it should match existing entity or can be * for
            /// unconditional update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedVirtualNetworkResource> CreateOrUpdateAsync(this IManagedVirtualNetworksOperations operations, string resourceGroupName, string factoryName, string managedVirtualNetworkName, ManagedVirtualNetworkResource managedVirtualNetwork, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, factoryName, managedVirtualNetworkName, managedVirtualNetwork, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a managed Virtual Network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='managedVirtualNetworkName'>
            /// Managed virtual network name
            /// </param>
            /// <param name='ifNoneMatch'>
            /// ETag of the managed Virtual Network entity. Should only be specified for
            /// get. If the ETag matches the existing entity tag, or if * was provided,
            /// then no content will be returned.
            /// </param>
            public static ManagedVirtualNetworkResource Get(this IManagedVirtualNetworksOperations operations, string resourceGroupName, string factoryName, string managedVirtualNetworkName, string ifNoneMatch = default(string))
            {
                return operations.GetAsync(resourceGroupName, factoryName, managedVirtualNetworkName, ifNoneMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a managed Virtual Network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='managedVirtualNetworkName'>
            /// Managed virtual network name
            /// </param>
            /// <param name='ifNoneMatch'>
            /// ETag of the managed Virtual Network entity. Should only be specified for
            /// get. If the ETag matches the existing entity tag, or if * was provided,
            /// then no content will be returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedVirtualNetworkResource> GetAsync(this IManagedVirtualNetworksOperations operations, string resourceGroupName, string factoryName, string managedVirtualNetworkName, string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, factoryName, managedVirtualNetworkName, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists managed Virtual Networks.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedVirtualNetworkResource> ListByFactoryNext(this IManagedVirtualNetworksOperations operations, string nextPageLink)
            {
                return operations.ListByFactoryNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists managed Virtual Networks.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedVirtualNetworkResource>> ListByFactoryNextAsync(this IManagedVirtualNetworksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFactoryNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}