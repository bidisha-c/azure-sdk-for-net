// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Documents
{
    /// <summary> Contains the error object with errors encountered for the processed document. </summary>
    public partial class AnalyzeDocumentsDocumentError
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

        /// <summary> Initializes a new instance of <see cref="AnalyzeDocumentsDocumentError"/>. </summary>
        /// <param name="id"> Document Id. </param>
        /// <param name="error"> Document Error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="error"/> is null. </exception>
        internal AnalyzeDocumentsDocumentError(string id, AnalyzeDocumentsError error)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(error, nameof(error));

            Id = id;
            Error = error;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeDocumentsDocumentError"/>. </summary>
        /// <param name="id"> Document Id. </param>
        /// <param name="error"> Document Error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeDocumentsDocumentError(string id, AnalyzeDocumentsError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeDocumentsDocumentError"/> for deserialization. </summary>
        internal AnalyzeDocumentsDocumentError()
        {
        }

        /// <summary> Document Id. </summary>
        public string Id { get; }
        /// <summary> Document Error. </summary>
        public AnalyzeDocumentsError Error { get; }
    }
}
