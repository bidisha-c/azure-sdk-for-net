// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Documents
{
    /// <summary> The object containing the analyze job LRO job state. </summary>
    public partial class AnalyzeDocumentsJobState
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

        /// <summary> Initializes a new instance of <see cref="AnalyzeDocumentsJobState"/>. </summary>
        /// <param name="createdAt"> Date and time job created. </param>
        /// <param name="lastUpdatedAt"> last updated date and time. </param>
        /// <param name="status"> status. </param>
        /// <param name="tasks"> List of tasks. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tasks"/> is null. </exception>
        internal AnalyzeDocumentsJobState(DateTimeOffset createdAt, DateTimeOffset lastUpdatedAt, DocumentActionState status, DocumentActions tasks)
        {
            Argument.AssertNotNull(tasks, nameof(tasks));

            CreatedAt = createdAt;
            LastUpdatedAt = lastUpdatedAt;
            Status = status;
            Errors = new ChangeTrackingList<AnalyzeDocumentsError>();
            Tasks = tasks;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeDocumentsJobState"/>. </summary>
        /// <param name="displayName"> display name. </param>
        /// <param name="createdAt"> Date and time job created. </param>
        /// <param name="expiresOn"> Date and time job expires. </param>
        /// <param name="jobId"> job ID. </param>
        /// <param name="lastUpdatedAt"> last updated date and time. </param>
        /// <param name="status"> status. </param>
        /// <param name="errors"> errors. </param>
        /// <param name="nextLink"> next link. </param>
        /// <param name="tasks"> List of tasks. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeDocumentsJobState(string displayName, DateTimeOffset createdAt, DateTimeOffset? expiresOn, Guid jobId, DateTimeOffset lastUpdatedAt, DocumentActionState status, IReadOnlyList<AnalyzeDocumentsError> errors, string nextLink, DocumentActions tasks, RequestStatistics statistics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            CreatedAt = createdAt;
            ExpiresOn = expiresOn;
            JobId = jobId;
            LastUpdatedAt = lastUpdatedAt;
            Status = status;
            Errors = errors;
            NextLink = nextLink;
            Tasks = tasks;
            Statistics = statistics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeDocumentsJobState"/> for deserialization. </summary>
        internal AnalyzeDocumentsJobState()
        {
        }

        /// <summary> display name. </summary>
        public string DisplayName { get; }
        /// <summary> Date and time job created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> Date and time job expires. </summary>
        public DateTimeOffset? ExpiresOn { get; }
        /// <summary> job ID. </summary>
        public Guid JobId { get; }
        /// <summary> last updated date and time. </summary>
        public DateTimeOffset LastUpdatedAt { get; }
        /// <summary> status. </summary>
        public DocumentActionState Status { get; }
        /// <summary> errors. </summary>
        public IReadOnlyList<AnalyzeDocumentsError> Errors { get; }
        /// <summary> next link. </summary>
        public string NextLink { get; }
        /// <summary> List of tasks. </summary>
        public DocumentActions Tasks { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
        public RequestStatistics Statistics { get; }
    }
}
