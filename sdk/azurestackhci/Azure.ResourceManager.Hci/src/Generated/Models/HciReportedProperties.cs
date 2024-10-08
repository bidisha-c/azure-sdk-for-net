// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The device Configuration for HCI device. </summary>
    public partial class HciReportedProperties : HciEdgeDeviceReportedProperties
    {
        /// <summary> Initializes a new instance of <see cref="HciReportedProperties"/>. </summary>
        internal HciReportedProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HciReportedProperties"/>. </summary>
        /// <param name="deviceState"> edge device state. </param>
        /// <param name="extensionProfile"> Extensions details for edge device. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="networkProfile"> HCI device network information. </param>
        /// <param name="osProfile"> HCI device OS specific information. </param>
        /// <param name="sbeDeploymentPackageInfo"> Solution builder extension (SBE) deployment package information. </param>
        internal HciReportedProperties(HciEdgeDeviceState? deviceState, HciEdgeDeviceExtensionProfile extensionProfile, IDictionary<string, BinaryData> serializedAdditionalRawData, HciNetworkProfile networkProfile, HciOSProfile osProfile, SbeDeploymentPackageInfo sbeDeploymentPackageInfo) : base(deviceState, extensionProfile, serializedAdditionalRawData)
        {
            NetworkProfile = networkProfile;
            OSProfile = osProfile;
            SbeDeploymentPackageInfo = sbeDeploymentPackageInfo;
        }

        /// <summary> HCI device network information. </summary>
        [WirePath("networkProfile")]
        public HciNetworkProfile NetworkProfile { get; }
        /// <summary> HCI device OS specific information. </summary>
        [WirePath("osProfile")]
        public HciOSProfile OSProfile { get; }
        /// <summary> Solution builder extension (SBE) deployment package information. </summary>
        [WirePath("sbeDeploymentPackageInfo")]
        public SbeDeploymentPackageInfo SbeDeploymentPackageInfo { get; }
    }
}
