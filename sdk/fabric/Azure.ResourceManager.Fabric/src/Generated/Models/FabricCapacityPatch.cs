// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Fabric.Models
{
    /// <summary> The type used for update operations of the FabricCapacity. </summary>
    public partial class FabricCapacityPatch
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FabricCapacityPatch"/>. </summary>
        public FabricCapacityPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="FabricCapacityPatch"/>. </summary>
        /// <param name="sku"> The SKU details. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FabricCapacityPatch(FabricSku sku, IDictionary<string, string> tags, FabricCapacityUpdateProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sku = sku;
            Tags = tags;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The SKU details. </summary>
        public FabricSku Sku { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The resource-specific properties for this resource. </summary>
        internal FabricCapacityUpdateProperties Properties { get; set; }
        /// <summary> An array of administrator user identities. </summary>
        public IList<string> AdministrationMembers
        {
            get
            {
                if (Properties is null)
                    Properties = new FabricCapacityUpdateProperties();
                return Properties.AdministrationMembers;
            }
        }
    }
}
