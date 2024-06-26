// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Collection name and id. </summary>
    public partial class PrivateStoreCollectionDetails
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

        /// <summary> Initializes a new instance of <see cref="PrivateStoreCollectionDetails"/>. </summary>
        internal PrivateStoreCollectionDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateStoreCollectionDetails"/>. </summary>
        /// <param name="collectionName"> Collection name. </param>
        /// <param name="collectionId"> Collection id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateStoreCollectionDetails(string collectionName, Guid? collectionId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CollectionName = collectionName;
            CollectionId = collectionId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Collection name. </summary>
        public string CollectionName { get; }
        /// <summary> Collection id. </summary>
        public Guid? CollectionId { get; }
    }
}
