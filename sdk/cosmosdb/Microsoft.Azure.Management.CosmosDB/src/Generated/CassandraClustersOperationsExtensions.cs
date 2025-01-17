// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CassandraClustersOperations.
    /// </summary>
    public static partial class CassandraClustersOperationsExtensions
    {
            /// <summary>
            /// List all managed Cassandra clusters in this subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<ClusterResource> ListBySubscription(this ICassandraClustersOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all managed Cassandra clusters in this subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ClusterResource>> ListBySubscriptionAsync(this ICassandraClustersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all managed Cassandra clusters in this resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static IEnumerable<ClusterResource> ListByResourceGroup(this ICassandraClustersOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all managed Cassandra clusters in this resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ClusterResource>> ListByResourceGroupAsync(this ICassandraClustersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the properties of a managed Cassandra cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            public static ClusterResource Get(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.GetAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the properties of a managed Cassandra cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ClusterResource> GetAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a managed Cassandra cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            public static void Delete(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName)
            {
                operations.DeleteAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a managed Cassandra cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or update a managed Cassandra cluster. When updating, you must
            /// specify all writable properties. To update only some properties, use PATCH.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='body'>
            /// The properties specifying the desired state of the managed Cassandra
            /// cluster.
            /// </param>
            public static ClusterResource CreateUpdate(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, ClusterResource body)
            {
                return operations.CreateUpdateAsync(resourceGroupName, clusterName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a managed Cassandra cluster. When updating, you must
            /// specify all writable properties. To update only some properties, use PATCH.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='body'>
            /// The properties specifying the desired state of the managed Cassandra
            /// cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ClusterResource> CreateUpdateAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, ClusterResource body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates some of the properties of a managed Cassandra cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='body'>
            /// Parameters to provide for specifying the managed Cassandra cluster.
            /// </param>
            public static ClusterResource Update(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, ClusterResource body)
            {
                return operations.UpdateAsync(resourceGroupName, clusterName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates some of the properties of a managed Cassandra cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='body'>
            /// Parameters to provide for specifying the managed Cassandra cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ClusterResource> UpdateAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, ClusterResource body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, clusterName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Request that repair begin on this cluster as soon as possible.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='body'>
            /// Specification of what keyspaces and tables to run repair on.
            /// </param>
            public static void RequestRepair(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, RepairPostBody body)
            {
                operations.RequestRepairAsync(resourceGroupName, clusterName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Request that repair begin on this cluster as soon as possible.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='body'>
            /// Specification of what keyspaces and tables to run repair on.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RequestRepairAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, RepairPostBody body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RequestRepairWithHttpMessagesAsync(resourceGroupName, clusterName, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Request the status of all nodes in the cluster (as returned by 'nodetool
            /// status').
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            public static ClusterNodeStatus FetchNodeStatus(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.FetchNodeStatusAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Request the status of all nodes in the cluster (as returned by 'nodetool
            /// status').
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ClusterNodeStatus> FetchNodeStatusAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FetchNodeStatusWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the backups of this cluster that are available to restore.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            public static IEnumerable<BackupResource> ListBackupsMethod(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.ListBackupsMethodAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the backups of this cluster that are available to restore.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<BackupResource>> ListBackupsMethodAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBackupsMethodWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the properties of an individual backup of this cluster that is
            /// available to restore.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='backupId'>
            /// Id of a restorable backup of a Cassandra cluster.
            /// </param>
            public static BackupResource GetBackup(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, string backupId)
            {
                return operations.GetBackupAsync(resourceGroupName, clusterName, backupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the properties of an individual backup of this cluster that is
            /// available to restore.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='backupId'>
            /// Id of a restorable backup of a Cassandra cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupResource> GetBackupAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, string backupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBackupWithHttpMessagesAsync(resourceGroupName, clusterName, backupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a managed Cassandra cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            public static void BeginDelete(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName)
            {
                operations.BeginDeleteAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a managed Cassandra cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or update a managed Cassandra cluster. When updating, you must
            /// specify all writable properties. To update only some properties, use PATCH.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='body'>
            /// The properties specifying the desired state of the managed Cassandra
            /// cluster.
            /// </param>
            public static ClusterResource BeginCreateUpdate(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, ClusterResource body)
            {
                return operations.BeginCreateUpdateAsync(resourceGroupName, clusterName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a managed Cassandra cluster. When updating, you must
            /// specify all writable properties. To update only some properties, use PATCH.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='body'>
            /// The properties specifying the desired state of the managed Cassandra
            /// cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ClusterResource> BeginCreateUpdateAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, ClusterResource body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates some of the properties of a managed Cassandra cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='body'>
            /// Parameters to provide for specifying the managed Cassandra cluster.
            /// </param>
            public static ClusterResource BeginUpdate(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, ClusterResource body)
            {
                return operations.BeginUpdateAsync(resourceGroupName, clusterName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates some of the properties of a managed Cassandra cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='body'>
            /// Parameters to provide for specifying the managed Cassandra cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ClusterResource> BeginUpdateAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, ClusterResource body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Request that repair begin on this cluster as soon as possible.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='body'>
            /// Specification of what keyspaces and tables to run repair on.
            /// </param>
            public static void BeginRequestRepair(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, RepairPostBody body)
            {
                operations.BeginRequestRepairAsync(resourceGroupName, clusterName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Request that repair begin on this cluster as soon as possible.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='body'>
            /// Specification of what keyspaces and tables to run repair on.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRequestRepairAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, RepairPostBody body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRequestRepairWithHttpMessagesAsync(resourceGroupName, clusterName, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Request the status of all nodes in the cluster (as returned by 'nodetool
            /// status').
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            public static ClusterNodeStatus BeginFetchNodeStatus(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.BeginFetchNodeStatusAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Request the status of all nodes in the cluster (as returned by 'nodetool
            /// status').
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// Managed Cassandra cluster name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ClusterNodeStatus> BeginFetchNodeStatusAsync(this ICassandraClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginFetchNodeStatusWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
