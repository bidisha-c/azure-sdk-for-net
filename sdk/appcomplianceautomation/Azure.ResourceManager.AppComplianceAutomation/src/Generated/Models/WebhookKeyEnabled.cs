// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> whether webhookKey is enabled. </summary>
    public readonly partial struct WebhookKeyEnabled : IEquatable<WebhookKeyEnabled>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebhookKeyEnabled"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebhookKeyEnabled(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "true";
        private const string FalseValue = "false";

        /// <summary> The webhookKey is enabled. </summary>
        public static WebhookKeyEnabled True { get; } = new WebhookKeyEnabled(TrueValue);
        /// <summary> The webhookKey is not enabled. </summary>
        public static WebhookKeyEnabled False { get; } = new WebhookKeyEnabled(FalseValue);
        /// <summary> Determines if two <see cref="WebhookKeyEnabled"/> values are the same. </summary>
        public static bool operator ==(WebhookKeyEnabled left, WebhookKeyEnabled right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebhookKeyEnabled"/> values are not the same. </summary>
        public static bool operator !=(WebhookKeyEnabled left, WebhookKeyEnabled right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebhookKeyEnabled"/>. </summary>
        public static implicit operator WebhookKeyEnabled(string value) => new WebhookKeyEnabled(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebhookKeyEnabled other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebhookKeyEnabled other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
