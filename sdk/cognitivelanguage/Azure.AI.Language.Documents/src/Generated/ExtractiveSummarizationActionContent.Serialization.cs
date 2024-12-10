// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Documents
{
    public partial class ExtractiveSummarizationActionContent : IUtf8JsonSerializable, IJsonModel<ExtractiveSummarizationActionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtractiveSummarizationActionContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExtractiveSummarizationActionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtractiveSummarizationActionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtractiveSummarizationActionContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(LoggingOptOut))
            {
                writer.WritePropertyName("loggingOptOut"u8);
                writer.WriteBooleanValue(LoggingOptOut.Value);
            }
            if (Optional.IsDefined(ModelVersion))
            {
                writer.WritePropertyName("modelVersion"u8);
                writer.WriteStringValue(ModelVersion);
            }
            if (Optional.IsDefined(SentenceCount))
            {
                writer.WritePropertyName("sentenceCount"u8);
                writer.WriteNumberValue(SentenceCount.Value);
            }
            if (Optional.IsDefined(SortBy))
            {
                writer.WritePropertyName("sortBy"u8);
                writer.WriteStringValue(SortBy.Value.ToString());
            }
            if (Optional.IsDefined(StringIndexType))
            {
                writer.WritePropertyName("stringIndexType"u8);
                writer.WriteStringValue(StringIndexType.Value.ToString());
            }
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ExtractiveSummarizationActionContent IJsonModel<ExtractiveSummarizationActionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtractiveSummarizationActionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtractiveSummarizationActionContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtractiveSummarizationActionContent(document.RootElement, options);
        }

        internal static ExtractiveSummarizationActionContent DeserializeExtractiveSummarizationActionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? loggingOptOut = default;
            string modelVersion = default;
            long? sentenceCount = default;
            ExtractiveSummarizationSortingCriteria? sortBy = default;
            StringIndexType? stringIndexType = default;
            string query = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loggingOptOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loggingOptOut = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sentenceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sentenceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sortBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sortBy = new ExtractiveSummarizationSortingCriteria(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stringIndexType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stringIndexType = new StringIndexType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExtractiveSummarizationActionContent(
                loggingOptOut,
                modelVersion,
                sentenceCount,
                sortBy,
                stringIndexType,
                query,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExtractiveSummarizationActionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtractiveSummarizationActionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExtractiveSummarizationActionContent)} does not support writing '{options.Format}' format.");
            }
        }

        ExtractiveSummarizationActionContent IPersistableModel<ExtractiveSummarizationActionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtractiveSummarizationActionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtractiveSummarizationActionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtractiveSummarizationActionContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtractiveSummarizationActionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ExtractiveSummarizationActionContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeExtractiveSummarizationActionContent(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
