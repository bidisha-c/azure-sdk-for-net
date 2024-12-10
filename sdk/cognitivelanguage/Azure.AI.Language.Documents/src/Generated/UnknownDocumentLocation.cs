// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Documents
{
    /// <summary> Unknown version of DocumentLocation. </summary>
    internal partial class UnknownDocumentLocation : DocumentLocation
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDocumentLocation"/>. </summary>
        /// <param name="kind"> The kind of the document location. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDocumentLocation(DocumentLocationKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownDocumentLocation"/> for deserialization. </summary>
        internal UnknownDocumentLocation()
        {
        }
    }
}
