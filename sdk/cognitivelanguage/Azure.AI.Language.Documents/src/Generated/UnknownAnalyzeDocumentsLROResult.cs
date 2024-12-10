// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Documents
{
    /// <summary> Unknown version of AnalyzeDocumentsLROResult. </summary>
    internal partial class UnknownAnalyzeDocumentsLROResult : AnalyzeDocumentsLROResult
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAnalyzeDocumentsLROResult"/>. </summary>
        /// <param name="lastUpdateDateTime"> The last updated time in UTC for the task. </param>
        /// <param name="status"> The status of the task at the mentioned last update time. </param>
        /// <param name="taskName"> task name. </param>
        /// <param name="kind"> Kind of the task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAnalyzeDocumentsLROResult(DateTimeOffset lastUpdateDateTime, DocumentActionState status, string taskName, AnalyzeDocumentsOperationResultsKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(lastUpdateDateTime, status, taskName, kind, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAnalyzeDocumentsLROResult"/> for deserialization. </summary>
        internal UnknownAnalyzeDocumentsLROResult()
        {
        }
    }
}
