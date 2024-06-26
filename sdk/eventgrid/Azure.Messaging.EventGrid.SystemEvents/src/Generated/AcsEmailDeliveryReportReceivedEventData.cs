// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.EmailDeliveryReportReceived event. </summary>
    public partial class AcsEmailDeliveryReportReceivedEventData
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

        /// <summary> Initializes a new instance of <see cref="AcsEmailDeliveryReportReceivedEventData"/>. </summary>
        /// <param name="status"> The status of the email. Any value other than Delivered is considered failed. </param>
        /// <param name="deliveryStatusDetails"> Detailed information about the status if any. </param>
        /// <param name="deliveryAttemptTimestamp"> The time at which the email delivery report received timestamp. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deliveryStatusDetails"/> is null. </exception>
        internal AcsEmailDeliveryReportReceivedEventData(AcsEmailDeliveryReportStatus status, AcsEmailDeliveryReportStatusDetails deliveryStatusDetails, DateTimeOffset deliveryAttemptTimestamp)
        {
            Argument.AssertNotNull(deliveryStatusDetails, nameof(deliveryStatusDetails));

            Status = status;
            DeliveryStatusDetails = deliveryStatusDetails;
            DeliveryAttemptTimestamp = deliveryAttemptTimestamp;
        }

        /// <summary> Initializes a new instance of <see cref="AcsEmailDeliveryReportReceivedEventData"/>. </summary>
        /// <param name="sender"> The Sender Email Address. </param>
        /// <param name="recipient"> The recipient Email Address. </param>
        /// <param name="messageId"> The Id of the email been sent. </param>
        /// <param name="status"> The status of the email. Any value other than Delivered is considered failed. </param>
        /// <param name="deliveryStatusDetails"> Detailed information about the status if any. </param>
        /// <param name="deliveryAttemptTimestamp"> The time at which the email delivery report received timestamp. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsEmailDeliveryReportReceivedEventData(string sender, string recipient, string messageId, AcsEmailDeliveryReportStatus status, AcsEmailDeliveryReportStatusDetails deliveryStatusDetails, DateTimeOffset deliveryAttemptTimestamp, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sender = sender;
            Recipient = recipient;
            MessageId = messageId;
            Status = status;
            DeliveryStatusDetails = deliveryStatusDetails;
            DeliveryAttemptTimestamp = deliveryAttemptTimestamp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AcsEmailDeliveryReportReceivedEventData"/> for deserialization. </summary>
        internal AcsEmailDeliveryReportReceivedEventData()
        {
        }

        /// <summary> The Sender Email Address. </summary>
        public string Sender { get; }
        /// <summary> The recipient Email Address. </summary>
        public string Recipient { get; }
        /// <summary> The Id of the email been sent. </summary>
        public string MessageId { get; }
        /// <summary> The status of the email. Any value other than Delivered is considered failed. </summary>
        public AcsEmailDeliveryReportStatus Status { get; }
        /// <summary> Detailed information about the status if any. </summary>
        public AcsEmailDeliveryReportStatusDetails DeliveryStatusDetails { get; }
        /// <summary> The time at which the email delivery report received timestamp. </summary>
        public DateTimeOffset DeliveryAttemptTimestamp { get; }
    }
}
