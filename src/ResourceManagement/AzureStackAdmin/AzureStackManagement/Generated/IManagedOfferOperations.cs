// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management
{
    /// <summary>
    /// Your documentation here.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
    /// more information)
    /// </summary>
    public partial interface IManagedOfferOperations
    {
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Your documentation here.
        /// </param>
        /// <param name='parameters'>
        /// Your documentation here.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        Task<ManagedOfferCreateOrUpdateResult> CreateOrUpdateAsync(string resourceGroupName, ManagedOfferCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Your documentation here.
        /// </param>
        /// <param name='offerId'>
        /// Your documentation here.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string offerId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Your documentation here.
        /// </param>
        /// <param name='offerId'>
        /// Your documentation here.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        Task<ManagedOfferGetResult> GetAsync(string resourceGroupName, string offerId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Your documentation here.
        /// </param>
        /// <param name='offerId'>
        /// Your documentation here.
        /// </param>
        /// <param name='metricDefinitionId'>
        /// Your documentation here.
        /// </param>
        /// <param name='filter'>
        /// Your documentation here.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        Task<ManagedOfferGetMetricDefinitionsResult> GetMetricDefinitionsAsync(string resourceGroupName, string offerId, string metricDefinitionId, string filter, CancellationToken cancellationToken);
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Your documentation here.
        /// </param>
        /// <param name='offerId'>
        /// Your documentation here.
        /// </param>
        /// <param name='metricId'>
        /// Your documentation here.
        /// </param>
        /// <param name='filter'>
        /// Your documentation here.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        Task<ManagedOfferGetMetricsResult> GetMetricsAsync(string resourceGroupName, string offerId, string metricId, string filter, CancellationToken cancellationToken);
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Your documentation here.
        /// </param>
        /// <param name='offerName'>
        /// Your documentation here.
        /// </param>
        /// <param name='parameters'>
        /// Your documentation here.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        Task<ManagedOfferLinkResult> LinkAsync(string resourceGroupName, string offerName, ManagedOfferLinkParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Your documentation here.
        /// </param>
        /// <param name='includeDetails'>
        /// Your documentation here.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        Task<ManagedOfferListResult> ListAsync(string resourceGroupName, bool includeDetails, CancellationToken cancellationToken);
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='nextLink'>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        Task<ManagedOfferListResult> ListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='includeDetails'>
        /// Your documentation here.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        Task<ManagedOfferListResult> ListWithoutResourceGroupAsync(bool includeDetails, CancellationToken cancellationToken);
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Your documentation here.
        /// </param>
        /// <param name='offerName'>
        /// Your documentation here.
        /// </param>
        /// <param name='parameters'>
        /// Your documentation here.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        Task<ManagedOfferUnlinkResult> UnlinkAsync(string resourceGroupName, string offerName, ManagedOfferUnlinkParameters parameters, CancellationToken cancellationToken);
    }
}