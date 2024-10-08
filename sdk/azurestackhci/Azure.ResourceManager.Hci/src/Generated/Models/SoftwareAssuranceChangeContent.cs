// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The SoftwareAssuranceChangeContent. </summary>
    public partial class SoftwareAssuranceChangeContent
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

        /// <summary> Initializes a new instance of <see cref="SoftwareAssuranceChangeContent"/>. </summary>
        public SoftwareAssuranceChangeContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SoftwareAssuranceChangeContent"/>. </summary>
        /// <param name="properties"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SoftwareAssuranceChangeContent(SoftwareAssuranceChangeRequestProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the properties. </summary>
        internal SoftwareAssuranceChangeRequestProperties Properties { get; set; }
        /// <summary> Customer Intent for Software Assurance Benefit. </summary>
        [WirePath("properties.softwareAssuranceIntent")]
        public SoftwareAssuranceIntent? SoftwareAssuranceIntent
        {
            get => Properties is null ? default : Properties.SoftwareAssuranceIntent;
            set
            {
                if (Properties is null)
                    Properties = new SoftwareAssuranceChangeRequestProperties();
                Properties.SoftwareAssuranceIntent = value;
            }
        }
    }
}
