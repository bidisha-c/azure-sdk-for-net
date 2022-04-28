// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ArcScVmm
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ArcScVmm. </summary>
    public static partial class ArcScVmmExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// List of VmmServers in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ScVmm/vmmServers
        /// Operation Id: VmmServers_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ScVmmServerResource> GetScVmmServersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetScVmmServersAsync(cancellationToken);
        }

        /// <summary>
        /// List of VmmServers in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ScVmm/vmmServers
        /// Operation Id: VmmServers_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ScVmmServerResource> GetScVmmServers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetScVmmServers(cancellationToken);
        }

        /// <summary>
        /// List of Clouds in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ScVmm/clouds
        /// Operation Id: Clouds_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmCloudResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ScVmmCloudResource> GetScVmmCloudsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetScVmmCloudsAsync(cancellationToken);
        }

        /// <summary>
        /// List of Clouds in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ScVmm/clouds
        /// Operation Id: Clouds_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmCloudResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ScVmmCloudResource> GetScVmmClouds(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetScVmmClouds(cancellationToken);
        }

        /// <summary>
        /// List of VirtualNetworks in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ScVmm/virtualNetworks
        /// Operation Id: VirtualNetworks_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmVirtualNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ScVmmVirtualNetworkResource> GetScVmmVirtualNetworksAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetScVmmVirtualNetworksAsync(cancellationToken);
        }

        /// <summary>
        /// List of VirtualNetworks in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ScVmm/virtualNetworks
        /// Operation Id: VirtualNetworks_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmVirtualNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ScVmmVirtualNetworkResource> GetScVmmVirtualNetworks(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetScVmmVirtualNetworks(cancellationToken);
        }

        /// <summary>
        /// List of VirtualMachines in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ScVmm/virtualMachines
        /// Operation Id: VirtualMachines_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmVirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ScVmmVirtualMachineResource> GetScVmmVirtualMachinesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetScVmmVirtualMachinesAsync(cancellationToken);
        }

        /// <summary>
        /// List of VirtualMachines in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ScVmm/virtualMachines
        /// Operation Id: VirtualMachines_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmVirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ScVmmVirtualMachineResource> GetScVmmVirtualMachines(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetScVmmVirtualMachines(cancellationToken);
        }

        /// <summary>
        /// List of VirtualMachineTemplates in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ScVmm/virtualMachineTemplates
        /// Operation Id: VirtualMachineTemplates_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmVirtualMachineTemplateResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ScVmmVirtualMachineTemplateResource> GetScVmmVirtualMachineTemplatesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetScVmmVirtualMachineTemplatesAsync(cancellationToken);
        }

        /// <summary>
        /// List of VirtualMachineTemplates in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ScVmm/virtualMachineTemplates
        /// Operation Id: VirtualMachineTemplates_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmVirtualMachineTemplateResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ScVmmVirtualMachineTemplateResource> GetScVmmVirtualMachineTemplates(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetScVmmVirtualMachineTemplates(cancellationToken);
        }

        /// <summary>
        /// List of AvailabilitySets in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ScVmm/availabilitySets
        /// Operation Id: AvailabilitySets_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmAvailabilitySetResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ScVmmAvailabilitySetResource> GetScVmmAvailabilitySetsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetScVmmAvailabilitySetsAsync(cancellationToken);
        }

        /// <summary>
        /// List of AvailabilitySets in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ScVmm/availabilitySets
        /// Operation Id: AvailabilitySets_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmAvailabilitySetResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ScVmmAvailabilitySetResource> GetScVmmAvailabilitySets(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetScVmmAvailabilitySets(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ScVmmServerResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ScVmmServerResources and their operations over a ScVmmServerResource. </returns>
        public static ScVmmServerCollection GetScVmmServers(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetScVmmServers();
        }

        /// <summary>
        /// Implements VMMServer GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}
        /// Operation Id: VmmServers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vmmServerName"> Name of the VMMServer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmmServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmmServerName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ScVmmServerResource>> GetScVmmServerAsync(this ResourceGroupResource resourceGroupResource, string vmmServerName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetScVmmServers().GetAsync(vmmServerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements VMMServer GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}
        /// Operation Id: VmmServers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vmmServerName"> Name of the VMMServer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmmServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmmServerName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ScVmmServerResource> GetScVmmServer(this ResourceGroupResource resourceGroupResource, string vmmServerName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetScVmmServers().Get(vmmServerName, cancellationToken);
        }

        /// <summary> Gets a collection of ScVmmCloudResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ScVmmCloudResources and their operations over a ScVmmCloudResource. </returns>
        public static ScVmmCloudCollection GetScVmmClouds(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetScVmmClouds();
        }

        /// <summary>
        /// Implements Cloud GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds/{cloudName}
        /// Operation Id: Clouds_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cloudName"> Name of the Cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ScVmmCloudResource>> GetScVmmCloudAsync(this ResourceGroupResource resourceGroupResource, string cloudName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetScVmmClouds().GetAsync(cloudName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements Cloud GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds/{cloudName}
        /// Operation Id: Clouds_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cloudName"> Name of the Cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ScVmmCloudResource> GetScVmmCloud(this ResourceGroupResource resourceGroupResource, string cloudName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetScVmmClouds().Get(cloudName, cancellationToken);
        }

        /// <summary> Gets a collection of ScVmmVirtualNetworkResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ScVmmVirtualNetworkResources and their operations over a ScVmmVirtualNetworkResource. </returns>
        public static ScVmmVirtualNetworkCollection GetScVmmVirtualNetworks(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetScVmmVirtualNetworks();
        }

        /// <summary>
        /// Implements VirtualNetwork GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualNetworks/{virtualNetworkName}
        /// Operation Id: VirtualNetworks_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="virtualNetworkName"> Name of the VirtualNetwork. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ScVmmVirtualNetworkResource>> GetScVmmVirtualNetworkAsync(this ResourceGroupResource resourceGroupResource, string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetScVmmVirtualNetworks().GetAsync(virtualNetworkName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements VirtualNetwork GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualNetworks/{virtualNetworkName}
        /// Operation Id: VirtualNetworks_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="virtualNetworkName"> Name of the VirtualNetwork. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ScVmmVirtualNetworkResource> GetScVmmVirtualNetwork(this ResourceGroupResource resourceGroupResource, string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetScVmmVirtualNetworks().Get(virtualNetworkName, cancellationToken);
        }

        /// <summary> Gets a collection of ScVmmVirtualMachineResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ScVmmVirtualMachineResources and their operations over a ScVmmVirtualMachineResource. </returns>
        public static ScVmmVirtualMachineCollection GetScVmmVirtualMachines(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetScVmmVirtualMachines();
        }

        /// <summary>
        /// Implements VirtualMachine GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachines/{virtualMachineName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="virtualMachineName"> Name of the VirtualMachine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ScVmmVirtualMachineResource>> GetScVmmVirtualMachineAsync(this ResourceGroupResource resourceGroupResource, string virtualMachineName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetScVmmVirtualMachines().GetAsync(virtualMachineName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements VirtualMachine GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachines/{virtualMachineName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="virtualMachineName"> Name of the VirtualMachine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ScVmmVirtualMachineResource> GetScVmmVirtualMachine(this ResourceGroupResource resourceGroupResource, string virtualMachineName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetScVmmVirtualMachines().Get(virtualMachineName, cancellationToken);
        }

        /// <summary> Gets a collection of ScVmmVirtualMachineTemplateResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ScVmmVirtualMachineTemplateResources and their operations over a ScVmmVirtualMachineTemplateResource. </returns>
        public static ScVmmVirtualMachineTemplateCollection GetScVmmVirtualMachineTemplates(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetScVmmVirtualMachineTemplates();
        }

        /// <summary>
        /// Implements VirtualMachineTemplate GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates/{virtualMachineTemplateName}
        /// Operation Id: VirtualMachineTemplates_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="virtualMachineTemplateName"> Name of the VirtualMachineTemplate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ScVmmVirtualMachineTemplateResource>> GetScVmmVirtualMachineTemplateAsync(this ResourceGroupResource resourceGroupResource, string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetScVmmVirtualMachineTemplates().GetAsync(virtualMachineTemplateName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements VirtualMachineTemplate GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates/{virtualMachineTemplateName}
        /// Operation Id: VirtualMachineTemplates_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="virtualMachineTemplateName"> Name of the VirtualMachineTemplate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ScVmmVirtualMachineTemplateResource> GetScVmmVirtualMachineTemplate(this ResourceGroupResource resourceGroupResource, string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetScVmmVirtualMachineTemplates().Get(virtualMachineTemplateName, cancellationToken);
        }

        /// <summary> Gets a collection of ScVmmAvailabilitySetResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ScVmmAvailabilitySetResources and their operations over a ScVmmAvailabilitySetResource. </returns>
        public static ScVmmAvailabilitySetCollection GetScVmmAvailabilitySets(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetScVmmAvailabilitySets();
        }

        /// <summary>
        /// Implements AvailabilitySet GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets/{availabilitySetName}
        /// Operation Id: AvailabilitySets_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="availabilitySetName"> Name of the AvailabilitySet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ScVmmAvailabilitySetResource>> GetScVmmAvailabilitySetAsync(this ResourceGroupResource resourceGroupResource, string availabilitySetName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetScVmmAvailabilitySets().GetAsync(availabilitySetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements AvailabilitySet GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets/{availabilitySetName}
        /// Operation Id: AvailabilitySets_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="availabilitySetName"> Name of the AvailabilitySet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ScVmmAvailabilitySetResource> GetScVmmAvailabilitySet(this ResourceGroupResource resourceGroupResource, string availabilitySetName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetScVmmAvailabilitySets().Get(availabilitySetName, cancellationToken);
        }

        #region ScVmmServerResource
        /// <summary>
        /// Gets an object representing a <see cref="ScVmmServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScVmmServerResource.CreateResourceIdentifier" /> to create a <see cref="ScVmmServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScVmmServerResource" /> object. </returns>
        public static ScVmmServerResource GetScVmmServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ScVmmServerResource.ValidateResourceId(id);
                return new ScVmmServerResource(client, id);
            }
            );
        }
        #endregion

        #region ScVmmCloudResource
        /// <summary>
        /// Gets an object representing a <see cref="ScVmmCloudResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScVmmCloudResource.CreateResourceIdentifier" /> to create a <see cref="ScVmmCloudResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScVmmCloudResource" /> object. </returns>
        public static ScVmmCloudResource GetScVmmCloudResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ScVmmCloudResource.ValidateResourceId(id);
                return new ScVmmCloudResource(client, id);
            }
            );
        }
        #endregion

        #region ScVmmVirtualNetworkResource
        /// <summary>
        /// Gets an object representing a <see cref="ScVmmVirtualNetworkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScVmmVirtualNetworkResource.CreateResourceIdentifier" /> to create a <see cref="ScVmmVirtualNetworkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScVmmVirtualNetworkResource" /> object. </returns>
        public static ScVmmVirtualNetworkResource GetScVmmVirtualNetworkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ScVmmVirtualNetworkResource.ValidateResourceId(id);
                return new ScVmmVirtualNetworkResource(client, id);
            }
            );
        }
        #endregion

        #region ScVmmVirtualMachineResource
        /// <summary>
        /// Gets an object representing a <see cref="ScVmmVirtualMachineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScVmmVirtualMachineResource.CreateResourceIdentifier" /> to create a <see cref="ScVmmVirtualMachineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScVmmVirtualMachineResource" /> object. </returns>
        public static ScVmmVirtualMachineResource GetScVmmVirtualMachineResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ScVmmVirtualMachineResource.ValidateResourceId(id);
                return new ScVmmVirtualMachineResource(client, id);
            }
            );
        }
        #endregion

        #region ScVmmVirtualMachineTemplateResource
        /// <summary>
        /// Gets an object representing a <see cref="ScVmmVirtualMachineTemplateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScVmmVirtualMachineTemplateResource.CreateResourceIdentifier" /> to create a <see cref="ScVmmVirtualMachineTemplateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScVmmVirtualMachineTemplateResource" /> object. </returns>
        public static ScVmmVirtualMachineTemplateResource GetScVmmVirtualMachineTemplateResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ScVmmVirtualMachineTemplateResource.ValidateResourceId(id);
                return new ScVmmVirtualMachineTemplateResource(client, id);
            }
            );
        }
        #endregion

        #region ScVmmAvailabilitySetResource
        /// <summary>
        /// Gets an object representing a <see cref="ScVmmAvailabilitySetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScVmmAvailabilitySetResource.CreateResourceIdentifier" /> to create a <see cref="ScVmmAvailabilitySetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScVmmAvailabilitySetResource" /> object. </returns>
        public static ScVmmAvailabilitySetResource GetScVmmAvailabilitySetResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ScVmmAvailabilitySetResource.ValidateResourceId(id);
                return new ScVmmAvailabilitySetResource(client, id);
            }
            );
        }
        #endregion

        #region InventoryItemResource
        /// <summary>
        /// Gets an object representing an <see cref="InventoryItemResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="InventoryItemResource.CreateResourceIdentifier" /> to create an <see cref="InventoryItemResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="InventoryItemResource" /> object. </returns>
        public static InventoryItemResource GetInventoryItemResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                InventoryItemResource.ValidateResourceId(id);
                return new InventoryItemResource(client, id);
            }
            );
        }
        #endregion
    }
}
