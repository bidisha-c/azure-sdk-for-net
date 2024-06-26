// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration account agreement content. </summary>
    public partial class IntegrationAccountAgreementContent
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

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountAgreementContent"/>. </summary>
        public IntegrationAccountAgreementContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountAgreementContent"/>. </summary>
        /// <param name="aS2"> The AS2 agreement content. </param>
        /// <param name="x12"> The X12 agreement content. </param>
        /// <param name="edifact"> The EDIFACT agreement content. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationAccountAgreementContent(AS2AgreementContent aS2, X12AgreementContent x12, EdifactAgreementContent edifact, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AS2 = aS2;
            X12 = x12;
            Edifact = edifact;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The AS2 agreement content. </summary>
        public AS2AgreementContent AS2 { get; set; }
        /// <summary> The X12 agreement content. </summary>
        public X12AgreementContent X12 { get; set; }
        /// <summary> The EDIFACT agreement content. </summary>
        public EdifactAgreementContent Edifact { get; set; }
    }
}
