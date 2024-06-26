// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary> The results of the vector query will filter based on the '@search.score' value. Note this is the @search.score returned as part of the search response. The threshold direction will be chosen for higher @search.score. </summary>
    public partial class SearchScoreThreshold : VectorThreshold
    {
        /// <summary> Initializes a new instance of <see cref="SearchScoreThreshold"/>. </summary>
        /// <param name="value"> The threshold will filter based on the '@search.score' value. Note this is the @search.score returned as part of the search response. The threshold direction will be chosen for higher @search.score. </param>
        public SearchScoreThreshold(double value)
        {
            Value = value;
            Kind = VectorThresholdKind.SearchScore;
        }

        /// <summary> Initializes a new instance of <see cref="SearchScoreThreshold"/>. </summary>
        /// <param name="kind"> The kind of threshold used to filter vector queries. </param>
        /// <param name="value"> The threshold will filter based on the '@search.score' value. Note this is the @search.score returned as part of the search response. The threshold direction will be chosen for higher @search.score. </param>
        internal SearchScoreThreshold(VectorThresholdKind kind, double value) : base(kind)
        {
            Value = value;
            Kind = kind;
        }

        /// <summary> The threshold will filter based on the '@search.score' value. Note this is the @search.score returned as part of the search response. The threshold direction will be chosen for higher @search.score. </summary>
        public double Value { get; set; }
    }
}
