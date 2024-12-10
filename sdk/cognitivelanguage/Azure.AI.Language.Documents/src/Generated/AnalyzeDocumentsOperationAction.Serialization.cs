// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Documents
{
    [PersistableModelProxy(typeof(UnknownAnalyzeDocumentsOperationAction))]
    public partial class AnalyzeDocumentsOperationAction : IUtf8JsonSerializable, IJsonModel<AnalyzeDocumentsOperationAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyzeDocumentsOperationAction>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AnalyzeDocumentsOperationAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeDocumentsOperationAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeDocumentsOperationAction)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        AnalyzeDocumentsOperationAction IJsonModel<AnalyzeDocumentsOperationAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeDocumentsOperationAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeDocumentsOperationAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeDocumentsOperationAction(document.RootElement, options);
        }

        internal static AnalyzeDocumentsOperationAction DeserializeAnalyzeDocumentsOperationAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AbstractiveSummarization": return AbstractiveSummarizationOperationAction.DeserializeAbstractiveSummarizationOperationAction(element, options);
                    case "ExtractiveSummarization": return ExtractiveSummarizationOperationAction.DeserializeExtractiveSummarizationOperationAction(element, options);
                    case "PiiEntityRecognition": return PiiEntityRecognitionOperationAction.DeserializePiiEntityRecognitionOperationAction(element, options);
                }
            }
            return UnknownAnalyzeDocumentsOperationAction.DeserializeUnknownAnalyzeDocumentsOperationAction(element, options);
        }

        BinaryData IPersistableModel<AnalyzeDocumentsOperationAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeDocumentsOperationAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalyzeDocumentsOperationAction)} does not support writing '{options.Format}' format.");
            }
        }

        AnalyzeDocumentsOperationAction IPersistableModel<AnalyzeDocumentsOperationAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeDocumentsOperationAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalyzeDocumentsOperationAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalyzeDocumentsOperationAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalyzeDocumentsOperationAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AnalyzeDocumentsOperationAction FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAnalyzeDocumentsOperationAction(document.RootElement);
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
